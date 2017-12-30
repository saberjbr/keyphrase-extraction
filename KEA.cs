using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Test
{
    class KEA
    {
        private string content = "";
        List<string> stopwords;
        List<wordClass> contentArray;
        public int totalWordCount;
        Stemming.Persian.Stemmer Stemmer;
        bool saveToDocs;
        public List<wordClass> resultList;
        public KEA(string content,bool saveToDocs)
        {
            totalWordCount = 0;
            this.content = content;
            this.saveToDocs = saveToDocs;
            Stemmer = new Stemming.Persian.Stemmer();
            stopwords = new List<string>();
            contentArray = new List<wordClass>();
            removeStopWords();
            replaceArablicAlphabets();
            crawleContentWithoutWordBaseAnalyse();
            calculateFrequncy();
            sortByfrequncy();
            searchWordOnOtherDocuments();
            calculateTDIDF();
            calculateResult();
            if (saveToDocs)
            {
                saveToDocuments(content);
            }
          
        }
        void removeStopWords()
        {
            iniitializeStopWords();
            for(int i = 0; i < stopwords.Count; i++)
            {
                content = content.Replace(" "+stopwords[i]+" ", " ");
            }
            

        }
        void iniitializeStopWords()
        {
            var filestream = new System.IO.FileStream(Environment.CurrentDirectory+"\\..\\..\\stopwords.txt",
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
            string s = String.Empty;
            while ((s = file.ReadLine()) != null)
            {
                stopwords.Add(s);
            }
        }
        void replaceArablicAlphabets()
        {
            //تعداد بیشتری حروف وجود دارد که در عربی و فارسی شکل جداگانه ای دارند ولی پر استفاده ترین موارد این دو هستند :)
            content=content.Replace("ی", "ی").Replace("ک", "ک");
        }
        private string getWordsBases(string str)
        {
            //using persian steaming
            return Stemmer.run(str);

        }
        void crawleContentWithWordBaseAnalyse()
        {
            int conter = 0;
            MatchCollection matches = Regex.Matches(content, @"[\w\d_]+", RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string rootWord = getWordsBases(match.Value);

                    // contentArray.Add(match.Value);
                    if (checkWordExists(rootWord) >-1)
                    {
                        //this word before inserted
                        contentArray.Find(x => x.word == rootWord).setRepeat(1);//increament repatation

                    }
                    else
                    {
                        //should be inserted
                        contentArray.Add(new wordClass(conter,rootWord,1,0,0));
                        conter++;
                    }
                }
             totalWordCount++;

            }
        }
        void crawleContentWithoutWordBaseAnalyse()
        {
            int conter = 0;
            MatchCollection matches = Regex.Matches(content, @"[\w\d_]+", RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                if (match.Success)
                {
                   
                    if (checkWordExists(match.Value) > -1)
                    {
                        //this word before inserted
                        contentArray.Find(x => x.word == match.Value).setRepeat(1);//increament repatation

                    }
                    else
                    {
                        //should be inserted
                        contentArray.Add(new wordClass(conter, match.Value, 1, 0,0));
                        conter++;
                    }
                }
            totalWordCount ++;

            }
        }

        public int checkWordExists(string word)
        {
            foreach(var tempWord in contentArray)
            {
                if (tempWord.word == word)
                {
                    return tempWord.index;
                }
            }
        return -1;
        }
        void calculateFrequncy()
        {
            foreach(var temp in contentArray)
            {
               
                temp.frequency = (double)temp.repeat / totalWordCount;
            }
        }
        void sortByfrequncy()
        {
          List<wordClass> sortedList= contentArray.OrderBy(x => x.frequency).ToList();
        }
        void searchWordOnOtherDocuments()
        {
            string[] docFiles = GetFileNames(Environment.CurrentDirectory + @"\\..\\..\\documents", "*.txt");
            foreach (var word in contentArray)
            {
                int containOnOtherDocs = 0;
                for(int i = 0; i < docFiles.Length; i++)
                {
                var filestream = new System.IO.FileStream(Environment.CurrentDirectory+ @"\\..\\..\\documents\\"+ docFiles[i],
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
                var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
                string s = String.Empty;
                while ((s = file.ReadLine()) != null)
                {
                    if (s.Contains(word.word))
                    {
                        containOnOtherDocs++;
                        break;
                    }

                }

                }
                word.TFIDF = (double)containOnOtherDocs / docFiles.Length;
               
            }   
        }
        public void saveToDocuments(string OriginalContent)
        {
            string[] docFiles = GetFileNames(Environment.CurrentDirectory + @"\\..\\..\\documents", "*.txt");

            string path = Environment.CurrentDirectory + @"\\..\\..\\documents\\"+(docFiles.Length+1).ToString()+@".txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(OriginalContent);
                    tw.Close();
                }

            }

        }
        private static string[] GetFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }
        void calculateTDIDF()
        {
            foreach(var word in contentArray)
            {
                word.TFIDF=(word.frequency)*(-(Math.Log(word.TFIDF,2)));//use logarithm func to calculate TD*IDF value
            }
        }
        void calculateResult()
        {
            resultList = contentArray.OrderBy(x => x.TFIDF).ToList();
            
        }
    }
}

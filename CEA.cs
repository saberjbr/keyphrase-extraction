using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class CEA
    {
        List<wordClass> Keywords;
        public string finalCategory;
        public CEA(List<wordClass> list)
        {
            Keywords = list;
            finalCategory = String.Empty;
            ProcessCategory();
        }
        public string ProcessCategory()
        {
            int score = 0;
            string category = String.Empty;
            string[] docFiles = GetFileNames(Environment.CurrentDirectory + @"\\..\\..\\categoryDocuments", "*.txt");
  
            foreach(var keyword in Keywords)
            {
                int thisFileScoreToThisKeyWord = 0;
                for(int i = 0; i < docFiles.Length; i++)
                {
                var filestream = new System.IO.FileStream(Environment.CurrentDirectory+ @"\\..\\..\\categoryDocuments\\" + docFiles[i],
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
                var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
                string s = String.Empty;
                while ((s = file.ReadLine()) != null)
                {
                    if (s.Contains(keyword.word))
                    {
                        thisFileScoreToThisKeyWord++;
                       
                    }

                }
                    if (thisFileScoreToThisKeyWord > score)
                    {
                        score = thisFileScoreToThisKeyWord;
                        category = docFiles[i].Replace(".txt", "");//مقایسه امتیاز متن کلیدی که برای دسته بندی در نظر گرفته شده با کلمات کلیدی
                    }
                }
            }
            finalCategory = category;
            return category;
        }
        private static string[] GetFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }
    }
}

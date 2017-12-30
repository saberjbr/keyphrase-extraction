using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class wordClass
    {
        public int index;
        public string word;
        public int repeat;
        public double frequency;
        public double TFIDF;
        
        public wordClass(int index,string word, int repeat, double freq,Double TFIDF)
        {
            this.index = index;
            this.word = word;
            this.repeat = repeat;
            this.frequency = freq;
            this.TFIDF = TFIDF;
        }
        public void setIndex(int indx)
        {
            this.index = indx;
        }
        public void setRepeat(int rpt)
        {
            this.repeat += rpt;
        }
        public void setFrequency(float freq)
        {
            this.frequency = freq;
        }
        public void setWord(string str)
        {
            this.word = str;
        }
        public int getIndex()
        {
            return this.index;
        }
        public int getRepeat()
        {
            return this.repeat;
        }
        public string getWord()
        {
            return this.word;
        }
        public double getFrequency()
        {
            return this.frequency;
        }
    }
}

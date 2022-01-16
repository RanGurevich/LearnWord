using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWord
{
    class Word
    {
        private int sucess;
        private string hebrew;
        private string english;
        private int were;

        public Word(string english, string hebrew)
        {
            this.sucess = 0;
            this.hebrew = hebrew;
            this.english = english;
            this.were = 0;
        }
        public void upSucess()
        {
            this.sucess++;
        }
        public void minusSucess()
        {
            this.sucess--;
        }
        public void upWere()
        {
            this.were++;
        }
        public string getHebrew()
        {
            return this.hebrew;
        }

        public string getEgnlish()
        {
            return this.english;
        }

        public int getSucess()
        {
            return this.sucess;
        }
        public int getWere()
        {
            return this.were;
        }


    }

}

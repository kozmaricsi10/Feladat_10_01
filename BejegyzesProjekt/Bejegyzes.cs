using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {

        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = letrejott;
        }

        public string Szerzo
        {
            get
            {
                return szerzo;
            }
        }

        public string Tartalom
        {
            get
            {
                return tartalom;
            }

            set
            {
                szerkesztve = DateTime.Now;

                tartalom = value;
            }
        }

        public int Likeok
        {
            get
            {

                return likeok;
            }
        }

        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }
        }

        public DateTime Szerkesztve
        {
            get
            {
                return szerkesztve;
            }
        }

        public void Like()
        {
            likeok += 1;
        }

        public string Kiir()
        {
            string s = "";

            if (szerkesztve != letrejott) {
                s = "\n" + "Szerkesztve: " + szerkesztve.ToString();
            }

            return szerzo + " - " + likeok.ToString() + " - " + letrejott.ToString() + s + "\n" + tartalom + "\n"; 
        }
        
    }
}

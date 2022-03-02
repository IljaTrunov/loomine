using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loomine
{
    class Inimene
    {
        string eesnimi;
        string sugu;
        string perenimi;
        string staatus;
        int vanus;
        int palk;
        Emakeel emakeel;
        public Emakeel Emakeel

        {
            get { return emakeel; }
        }
        public Inimene() { }
        public Inimene(string Perenimi, Emakeel emakeel)
        {
            perenimi = Perenimi;
            this.emakeel = emakeel;
        }
        public Inimene(string eesnimi, string perenimi)
        {
            Eesnimi = eesnimi;
            Perenimi = perenimi;
        }
        public string Sugu
        {
            set { if (sugu == null) sugu = value; }
            get { return sugu; }
        }
        public string Eesnimi
        {
            set { if (eesnimi == null) eesnimi = value; }
            get { return eesnimi; }
        }
        public string Perenimi
        {
            set { if (perenimi == null) perenimi = value; }
            get { return perenimi; }
        }
        public int Vanus
        {
            set
            {
                vanus = value;
            }
            get { return vanus; }
        }
        public string Staatus
        {
            get
            {
                if (vanus < 7)
                {
                    staatus = "laps";
                }
                else if (vanus < 17)
                {
                    staatus = "koolilaps";
                }
                else if (vanus < 24)
                {
                    staatus = "ülikoolilaps";
                }
                else
                {
                    staatus = "tööline";
                }
                return staatus;
            }
        }
        public int Palk
        {
            set
            {
                palk = value;
                if (palk < 450)
                {
                    staatus = "õpilane";
                }
                else if (palk < 800)
                {
                    staatus = "Lihtsalt inimene";
                }
                else if (palk < 1200)
                {
                    staatus = "rikas";
                }
                else
                {
                    staatus = "kodutu";
                }
            }
        }
        public double Sotsialmaks()
        {
            double sots = 0;
            sots = palk * 0.33;

            return sots;
        }

        public void tervitamine()
        {
            if (perenimi!=null && eesnimi!=null)
            {
                Console.WriteLine("Tere! minu nimi on {0} {1}", eesnimi, perenimi);
            }
            else if (perenimi == null && eesnimi!=null)
            {
                Console.WriteLine("Tere! minu eesnimi on "+eesnimi);
            }
            else if (eesnimi == null && perenimi!=null)
            {
                Console.WriteLine("Tere! minu perenimi on "+perenimi);
            }
            else
            {
                Console.WriteLine("Tere!");
            }
            Console.WriteLine("tere! minu perenimi on "+perenimi);
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}",vanus,staatus,sugu,palk);
        }
    }
}

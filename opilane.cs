using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loomine
{
    class opilane
    {
        string ruhm;
        double hinne;
        bool toetus;
        private int eesnimi;
        private int perenimi;

        public opilane() { }

        public opilane(string Eesnimi, string Perenimi, string Ruhm)
        {
            ruhm = Ruhm;
        }

        public string Ruhm
        {
            set { ruhm = value; }
            get { return ruhm; }
        }

        public double Hinne
        {
            set { if (value > 0 && value <= 5) hinne = value; }
            get { return hinne; }
        }

        public bool toetues
        {
            get
            {
                if (hinne > 3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            }
        }

        public void Informatsioon()
        {
            string t = "";
            Console.WriteLine("Tere! Minu nimi on {0} {1}", eesnimi, perenimi);
            if (toetus == true)
            {
                t = ":)";
            }
            else if (toetus == false && hinne > 0)
            {
                t = ":(";
            }
            else
            {
                t = "0_0";
            }
            Console.WriteLine("Minu keskmine hinne on {0}. {1}", hinne, t, ":D");

        }

        public abstract void kes_ma_olen()
        {
            Console.WriteLine("Ma olen õpilane");
        }
    }
}

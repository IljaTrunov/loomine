using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loomine
{
    public class opetaja : Inimene
    {
        string aine;
        public opetaja() { }

        public string Aine
        {
            set { aine = value; }
            get { return aine; }
        }

        public override void kes_ma_olen()
        {
            Console.WriteLine("Ma olen õpetaja");
        }
    }
}

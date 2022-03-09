using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loomine
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimene i = new opilane("Anna", "Tamm", "Tarpe21");
            i.kes_ma_olen(); 
            i.tervitamine();
            Inimene[] inim = new Inimene[4];


            Inimene[] inim = new Inimene[4];
            inim[0] = new opetaja();
            inim[0].kes_ma_olen();
            inim[1] = new opilane();
            inim[1].kes_ma_olen();


            opilane poiss1 = new opilane();
            poiss1.Nimi = "gei";
            poiss1.Perenimi = "homo";
            poiss1.ruhm = "tarpv22";
            Console.WriteLine("Milline on sinu hinne");
            poiss1.Hinne = int.Parse(Console.ReadLine());
            poiss1.Informatsioon();

            Inimene naine = new Inimene("loshara","galya");
            naine.Palk = 100;
            double s = naine.Sotsialmaks();
            Console.WriteLine(s);
            Console.WriteLine("Kui vana sa oled");
            naine.Vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Missugune on sinu palk?");
            naine.Palk = int.Parse(Console.ReadLine());
            naine.tervitamine();

            Inimene mees = new Inimene();
            mees.Perenimi = "Tamm";
            mees.Vanus = 69;
            mees.Palk = 1000;
           // Console.WriteLine(mees.Perenimi+" on "+mees.Vanus+" aastane mees", "palk on "+mees.palk);
            mees.tervitamine();
            Inimene[] inimesed = new Inimene[5];
            for (int i = 0; i < 5; i++)
            {
                inimesed[1] = new Inimene();
                Console.WriteLine("Mis on sinu nimi");
                inimesed[i].Perenimi = Console.ReadLine();
                Console.WriteLine("Kui vana sa oled? Kuradi pidur...");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.tervitamine();
            }
            Console.ReadKey();
        }
    }
}

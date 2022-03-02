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

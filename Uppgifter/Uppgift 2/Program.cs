using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2
{
    class Program
    {
    static void Main(string[] args)
        {
            //Låt användaren mata in en mening.
            Console.WriteLine("Skriv en mening");
            string mening = Console.ReadLine();

            //Skriv ut varje ord på en egen rad, i storleksordning(längd på ordet)
            //Skriv ut varje ord på en egen rad, i omvänd ordning(baklänges)
            Console.WriteLine(mening);
            Console.Read();
        }
    }
}

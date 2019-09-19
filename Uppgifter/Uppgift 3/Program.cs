using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Låt användaren mata in en mening.
            Console.WriteLine("Skriv in en mening");
            string mening = Console.ReadLine();
            string[] words = mening.Split();
            //Skriv ut varje unikt ord på en egen rad, och ange hur ofta ordet förekommer(ex "och (2)")
            int matchCount = 0;
            System.Collections.ArrayList Blacklist = new System.Collections.ArrayList();
            Blacklist.Add(" ");
            bool ban = false;
            foreach (string ord in words)
             {

                foreach (string Listedword in Blacklist)
                {
                    if (Listedword.Equals(ord) == true)
                    {
                        ban = true;
                    }
                }
                if (ban != true)
                {
                    foreach (string CompareOrd in words)
                    {

                        if (CompareOrd.Equals(ord) == true)
                        {
                            matchCount++;

                        }

                    }

                    Console.WriteLine("{0} {1}", ord, matchCount);
                  
                    Blacklist.Add(ord);
                    matchCount = 0;

                }
                ban = false;

            }

            //Skriv ut varje unikt ord på en egen rad, sorterat efter hur ofta ordet förekommer




            Console.Read();
        }
    }
}

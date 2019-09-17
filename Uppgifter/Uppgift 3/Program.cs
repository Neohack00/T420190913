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
         

            Console.WriteLine("skriv en mening");
            string mening = Console.ReadLine();
            string[] words = mening.Split(' ');// Vi har en method som kan räkna orden samt array som förvara dem
            ////Console.WriteLine(words.Length);//Test körnings utskrift
   
            Dictionary<string, int> OrdKollen = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string Compare = words[i];
                for (int x = 0; i < words.Length; x++)
                {
                    int matching = string.Compare(Compare, words[x]);
                    if (matching != 0)
                    {
                        OrdKollen.Add(words[x], 1);
                    }
                    else if (matching == 0)
                    {
                        Dictionary<string, string>.ValueCollection valueColl = OrdKollen.Values;
                        Console.WriteLine();
                        foreach (string s in valueColl)
                        {
                            Console.WriteLine("Value = {0}", s);
                        }


                        OrdKollen[Compare] = +1;

                    }
                }
            }


            Console.Read();
        }
    }
}

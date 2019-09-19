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
             
            ////Låt användaren mata in en mening.
            Console.WriteLine("Write in an sentence");
            string mening = Console.ReadLine();
            mening.Trim(' ');
            string[] inputwords = mening.Split(' ');
            //Skriv ut varje ord på en egen rad, i storleksordning(längd på ordet)
            //Skriv ut varje ord på en egen rad, i omvänd ordning(baklänges)
            System.Collections.ArrayList words = new System.Collections.ArrayList();
            Console.WriteLine("\n|Original order of the sentence |\n");
            foreach (string word in inputwords)
            {
                Console.WriteLine("{0} ({1})", word, word.Length);
            }
            Console.WriteLine("\n|Sorting after word size|\n");
            Array.Sort(inputwords, (a, b) => a.Length.CompareTo(b.Length));// Sortera stringen i storleks ordning
            foreach (string word in inputwords)
            {
                Console.WriteLine("{0} ({1})",word, word.Length);
            }
            Array.Reverse(inputwords, 0, inputwords.Length);// Omvänder ordningen
            Console.WriteLine("\n|Reverse the order|\n");
            {
            foreach (string word in inputwords)
            {
               Console.WriteLine("{0} ({1})",word, word.Length);
            }


                Console.Read();
        }
 
        

           
        }
    }
}

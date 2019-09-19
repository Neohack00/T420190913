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
            Console.WriteLine("skriv en mening");
            string mening = Console.ReadLine();
            mening.Trim(' ', ',');
            string[] inputwords = mening.Split(' ');
            //Skriv ut varje ord på en egen rad, i storleksordning(längd på ordet)
            System.Collections.ArrayList words = new System.Collections.ArrayList();
            foreach (string ord in inputwords)
            {
                
                words.Add(ord);
            }

            ;
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            {
                

                //Skriv ut varje ord på en egen rad, i omvänd ordning(baklänges)
                Console.Read();
        }
 
        

           
        }
    }
}

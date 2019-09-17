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
            string[] words = mening.Split(' ');
            //Skriv ut varje ord på en egen rad, i storleksordning(längd på ordet)
           
            int MaxLen = 0;
            int MinstLen = 0;
            
            foreach (string ord in words)
            {

                if (MaxLen < ord.Length)
                {
                    MaxLen = ord.Length;

                    if (MinstLen == 0 )
                    {
                        MinstLen = MaxLen;
                    }
                }
                else if(ord.Length < MinstLen)
                {
                    MinstLen = ord.Length;
                }
            }
            string[] Sortedwords = new string[words.Length];

            foreach(string ord in words)
            {
                if (MaxLen == ord.Length)
                {
                    Sortedwords[0] = ord;
                }
                else if(MinstLen == ord.Length)
                {
                    Sortedwords[words.Length - 1] =  ord;
                }
            

            }

            Console.WriteLine("Störst ordvärde är {0} och minsta är {1}", MaxLen, MinstLen);
            foreach(string ord in words)
            {
                Console.WriteLine("{0} : ({1})", ord , ord.Length);
            }
            


            //Skriv ut varje ord på en egen rad, i omvänd ordning(baklänges)
            Console.Read();
        }
    }
}

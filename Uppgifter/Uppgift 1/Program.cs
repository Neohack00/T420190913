using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Skriv in en mening");
            string mening = ReadLine();
            mening = mening + " ";
            int ordLength = mening.Length;
            int wordCount = 0;     
            int checkpoint = 0;
            int wordLen = 0;
            
            for (int i = 0; i < ordLength; i++)
            {
                
                if (mening[i] == ' ' )
                {

                    wordCount++;
                    wordLen = i - checkpoint;
                    for(int y = checkpoint; y < i; y++)
                    {
                        char word = mening[y];
                        Write(word);
                        
                    }
                    checkpoint = i + 1;
                    Write("   Antal karaktärer " + wordLen + "\n");
                    
           
                }
                
            }


            Write(" Antal ord :" + wordCount);


            Read();
            
        }
    }
}

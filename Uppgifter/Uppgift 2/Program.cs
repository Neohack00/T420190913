﻿using System;
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
            string[] words = mening.Split(' ');// Vi har en method som kan räkna orden samt array som förvara dem
            ////Console.WriteLine(words.Length);//Test körnings utskrift
            //Skriv ut varje ord på en egen rad, i storleksordning(längd på ordet)
            //Skulle behöver en funktion som sorterar arrayen efter storlek
            

            //Skriv ut varje ord på en egen rad, i omvänd ordning(baklänges)
            //Console.WriteLine(mening);
            Console.Read();
        }
    }
}

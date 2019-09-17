using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
         ArrayList Alist = new ArrayList();
            Alist.Add("Hej");
            Alist.Add("Neo");
            Alist.Add("!");

            Console.WriteLine(Alist);
            Console.WriteLine("Alist");
            Console.WriteLine(" Count:  {0}", Alist.Count);
            Console.WriteLine(" Capacity:   {0} ", Alist.Capacity);
            Console.WriteLine("Values:    ");
            foreach(Object Sak in Alist)
            {
                Console.WriteLine("    {0}", Sak);
            }
            Console.ReadLine();

        }
    }
}

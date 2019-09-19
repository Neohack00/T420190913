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
            //ArrayList Alist = new ArrayList();
            //   Alist.Add("Hej");
            //   Alist.Add("Neo");
            //   Alist.Add("!");

            //   Console.WriteLine(Alist);
            //   Console.WriteLine("Alist");
            //   Console.WriteLine(" Count:  {0}", Alist.Count);
            //   Console.WriteLine(" Capacity:   {0} ", Alist.Capacity);
            //   Console.WriteLine("Values:    ");
            //   foreach(Object Sak in Alist)
            //   {
            //       Console.WriteLine("    {0}", Sak);
            //   }
            //   Console.ReadLine();

            int y = 0;
            int[,] TwoD = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    TwoD[i, j] = y;
                    y++;
                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; i < 3; j++)
                {
                    Console.WriteLine("Row {0} Column{1} = {2}", i, j, TwoD[i, j]);
              
                }
            }
            Console.Read();

        }
    }
}

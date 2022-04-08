using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, j, i;

            for (j = 2; j <= 100; j++)
            { //por definicion el 1 no es primo, se empieza en 2
                a = 0;
                for (i = 1; i <= 100; i++)//divide a j entre los números del 1 al 100
                {
                    if (j % i == 0) 
                        a++;
                }
                if (a == 2)
                { 

                    Console.WriteLine("");
                    Console.ReadKey();
                }
            }
        }
    }
}

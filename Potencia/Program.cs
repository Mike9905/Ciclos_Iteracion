using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Dime un numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dime otro numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            double potencia = 1;

            int exponente = num2;
            if (num2 < 0) exponente = -num2;

            int i = 1;
            while (i <= exponente)
            {
                potencia *= num1;
                i++;
            }
            if (num2 < 0) potencia = 1 / potencia;
            Console.WriteLine(potencia);
            Console.ReadKey();
        }
    }
}

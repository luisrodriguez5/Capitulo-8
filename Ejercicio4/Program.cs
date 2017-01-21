using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int Suma = n1 + n2;
            String Result = " ";
            if (Suma > 0)
                Result = Suma.ToString();
            else
                Result = "(" + Suma + ")";
            Console.WriteLine("La suma es igual a: " + Result);
            Console.ReadKey();

        }
    }
}

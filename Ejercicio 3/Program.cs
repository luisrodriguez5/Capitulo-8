using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Fecha = new DateTime(2017, 1, 21);
            DateTime FechaHora = new DateTime(2017, 01, 21, 01, 56, 40);
            Console.WriteLine("La fecha es:" + FechaHora.ToString("h : mm : ss : tt / yyyy/MM/dddd"));
            Console.ReadKey();
        }
    }
}

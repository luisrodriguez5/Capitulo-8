using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            String Cadena;
            String Opcion;
            int Op;
            Console.WriteLine("Ingrese una Cadena: ");
            Cadena = Console.ReadLine();
            Console.WriteLine("Como desea justificar la cadena:\n1.Justificar hacia la izquierdad\n2.Justificar hacia la derecha");
            Opcion = Console.ReadLine();
            Op = Convert.ToInt32(Opcion);
            if (Op == 1)
            {
                Console.WriteLine("la cadena Original: \n " + Cadena);
                Cadena = Cadena.PadLeft(20);
                Console.WriteLine("Cadena Justificada: \n" + Cadena);



            }
            if (Op == 2)
            {

                Console.WriteLine("la cadena Original: \n " + Cadena);
                Cadena = Cadena.PadRight(20);
                Console.WriteLine("Cadena Justificada: \n" + Cadena);
            }

            Console.ReadKey();
        }
    }
}

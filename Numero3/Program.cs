using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.WriteLine("Presione teclas. X para salir");
                tecla = Console.ReadKey(true);

            } while (tecla.Key != ConsoleKey.X);
        }
    }
}

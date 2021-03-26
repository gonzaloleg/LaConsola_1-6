using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            Console.WriteLine("Ingrese texto:");
            ingreso = Console.ReadLine();
            Console.WriteLine($"Usted ingreso {ingreso}");
            Console.ReadKey();
        }
    }
}

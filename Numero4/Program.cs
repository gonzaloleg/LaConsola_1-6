using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero4
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            do
            {
                Console.WriteLine("Ingrese frase. Solo se sale con 'fin'.");
                frase = Console.ReadLine();

            } while (frase != "fin");
        }
    }
}

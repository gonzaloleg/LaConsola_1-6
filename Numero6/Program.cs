using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey();
                Console.WriteLine();
                if ((tecla.Key == ConsoleKey.F) &&
                    (tecla.Modifiers & ConsoleModifiers.Control) != 0 &&
                        (tecla.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    break;
                }

            } while (true);
            
        }
    }
}

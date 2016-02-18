using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTenta
{
    class Program
    {

        static void Main(string[] args)
        {
            var uppg1 = new Uppgift1();
            uppg1.RunConsole();

            Console.WriteLine("Tryck på valfri tangent för att avsluta programmet");
            Console.ReadKey();
        }
    }
}

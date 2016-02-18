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
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Hej, välj uppgift:");
                Console.WriteLine("1. Uppgift 1");
                Console.WriteLine("7. Uppgift 7");
                int val;
                int.TryParse(Console.ReadLine(), out val);
                if(val == 1)
                {
                    var uppg1 = new Uppgift1();
                    uppg1.RunConsole();
                }
                else if(val == 7)
                {
                    var uppg7 = new Uppgift7();
                    uppg7.RunConsole();
                }
            }
        }
    }
}

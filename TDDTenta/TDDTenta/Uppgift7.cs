using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTenta
{
    public class Uppgift7
    {
        // Tre olika åldersgrupper
        int vuxna;
        int ungdom;
        int barn;

        public Uppgift7()
        {
            vuxna = 0;
            ungdom = 0;
            barn = 0;
        }

        public bool IsWeekend { get; set; }

        public void AddFamilyMember(int age)
        {
            // Vuxen (Över 15 år)
            if(age > 15)
            {
                vuxna++;
            }
            // Ungdom (7 till 15 år)
            else if(age > 6)
            {
                ungdom++;
            }
            // Barn (1 till 6 år)
            else if(age > 0)
            {
                barn++;
            }
            else
            {
                throw new Exception("Ogiltig ålder");
            }
        }

        public int GetTotalPrice()
        {
            int biljettpris = 100;
            int totalPrice = 0;

            if(IsWeekend == true)
            {
                // Dubbla det normala biljettpriset om det är helg
                biljettpris *= 2;
            }

            totalPrice += vuxna * biljettpris;
            totalPrice += (ungdom * biljettpris) / 2;

            return totalPrice;
        }

        public void RunConsole()
        {
            Console.WriteLine("Uppgift 7");
            /*
            while (true)
            {
                Console.WriteLine("Fyll i slutår: (exempelvis '2016')");
                int endYear;
                int.TryParse(Console.ReadLine(), out endYear);
                try
                {
                    Console.WriteLine(String.Format("Antal invånare efter {0} år är {1}", endYear - startYear, RaknaUtInvanare(endYear)));
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            */
        }

    }
}

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
            Console.Clear();
            Console.WriteLine("Uppgift 7");
            while(true)
            {
                Console.WriteLine("Ange ålder på familjemedlem: ");
                try
                {
                    int age;
                    int.TryParse(Console.ReadLine(), out age);
                    AddFamilyMember(age);

                    Console.WriteLine("Tryck på 'N' för att lägga till en ny familjemedlem");
                    Console.WriteLine("Tryck på någon annan tangent för att beräkna totalpriset");
                    var pressedKey = Console.ReadKey();
                    if (pressedKey.Key.ToString().ToLower() == "n")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Tryck på 'H' om du vill beräkna till helgpris");
                        Console.WriteLine("Tryck på någon annan tangent för att beräkna vardagspris");
                        if (Console.ReadKey().Key.ToString().ToLower() == "h")
                        {
                            IsWeekend = true;
                        }
                        Console.Clear();

                        int biljettpris;
                        if(IsWeekend == true)
                        {
                            Console.WriteLine("[Helgpriser]");
                            biljettpris = 200;
                        }
                        else
                        {
                            Console.WriteLine("[Vardagspriser]");
                            biljettpris = 100;
                        }

                        Console.WriteLine(String.Format("{0} st vuxna \t {1} kr", vuxna, vuxna * biljettpris));
                        Console.WriteLine(String.Format("{0} st ungdomar \t {1} kr", ungdom, (ungdom * biljettpris / 2) ));
                        Console.WriteLine(String.Format("{0} st barn \t {1} kr", barn, 0));
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine(String.Format("Totalpris: {0} kr", GetTotalPrice()));
                        break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadKey();
        }

    }
}

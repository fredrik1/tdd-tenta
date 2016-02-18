using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTenta
{
    public class Uppgift1
    {
        int maximumEndYear = 2100;

        public double RaknaUtInvanare(int? endYear)
        {
            if(endYear == null)
            {
                throw new ArgumentNullException();
            }
            else if (endYear == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (endYear < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (endYear > maximumEndYear)
            {
                throw new Exception(String.Format("År {0} är större än max tillåtna år.", endYear));
            }
            else if(endYear < 2015)
            {
                throw new Exception("Kan inte ange ett tidigare år än 2015.");
            }

            double invanare = 26000;
            double inflytt = 300;
            double utflytt = 325;
            double fodda = 0;
            double doda = 0;

            for (int startYear = 2015; startYear < endYear; startYear++)
            {
                fodda += 0.007 * 26000;
                doda += 0.006 * 26000;

                invanare += inflytt;
                invanare -= utflytt;
                invanare += fodda;
                invanare -= doda;
            }
            return invanare;
        }

        public void RunConsole()
        {
            int startYear = 2015;
            Console.WriteLine("Uppgift 1");

            while(true)
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

        }
    }
}

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
        }

        public void SetDayOfWeek(int v)
        {
            throw new NotImplementedException();
        }

        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}

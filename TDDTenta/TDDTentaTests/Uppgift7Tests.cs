using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTenta;

namespace TDDTentaTests
{
    [TestClass]
    public class Uppgift7Tests
    {

        [TestMethod]
        public void Uppg7_TestTotalCostForFamilyOnWednesday()
        {
            var uppg7 = new Uppgift7();

            int expectedTotalCost = 0;

            uppg7.AddFamilyMember(57);
            expectedTotalCost += 100;
            uppg7.AddFamilyMember(55);
            expectedTotalCost += 100;
            uppg7.AddFamilyMember(16);
            expectedTotalCost += 50;
            uppg7.AddFamilyMember(12);
            expectedTotalCost += 50;
            uppg7.AddFamilyMember(4);
            expectedTotalCost += 0;

            // Sätt veckodagen till Onsdag
            uppg7.SetDayOfWeek(3);

            Assert.AreEqual(expectedTotalCost, uppg7.GetTotalPrice());
        }

        [TestMethod]
        public void Uppg7_TestTotalCostForFamilyOnSunday()
        {
            var uppg7 = new Uppgift7();

            int expectedTotalCost = 0;

            uppg7.AddFamilyMember(57);
            expectedTotalCost += 200;
            uppg7.AddFamilyMember(55);
            expectedTotalCost += 200;
            uppg7.AddFamilyMember(16);
            expectedTotalCost += 200;
            uppg7.AddFamilyMember(12);
            expectedTotalCost += 200;
            uppg7.AddFamilyMember(4);
            expectedTotalCost += 200;

            // Sätt veckodagen till Söndag
            uppg7.SetDayOfWeek(7);

            Assert.AreEqual(expectedTotalCost, uppg7.GetTotalPrice());
        }

        [TestMethod]
        public void Uppg7_TestAddFamilyMemberWithNegativeAge()
        {
            var uppg7 = new Uppgift7();
            uppg7.AddFamilyMember(-1);
        }


        [TestMethod]
        public void Uppg7_TestAddFamilyMemberWithAgeZero()
        {
            var uppg7 = new Uppgift7();
            uppg7.AddFamilyMember(0);
        }
    }
}

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
            expectedTotalCost += 100;
            uppg7.AddFamilyMember(12);
            expectedTotalCost += 50;
            uppg7.AddFamilyMember(4);
            expectedTotalCost += 0;

            // Non Weekend
            uppg7.IsWeekend = false;

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
            expectedTotalCost += 100;
            uppg7.AddFamilyMember(4);
            expectedTotalCost += 0;

            // Sätt veckodagen till helgdag
            uppg7.IsWeekend = true;

            Assert.AreEqual(expectedTotalCost, uppg7.GetTotalPrice());
        }

        [TestMethod]
        public void Uppg7_TestAddFamilyMemberWithNegativeAge()
        {
            string errMsg = "";
            var uppg7 = new Uppgift7();
            try
            {
                uppg7.AddFamilyMember(-1);
            }
            catch (Exception e)
            {
                errMsg = e.Message;
            }
            Assert.AreEqual("Ogiltig ålder", errMsg);
        }


        [TestMethod]
        public void Uppg7_TestAddFamilyMemberWithAgeZero()
        {
            string errMsg = "";
            var uppg7 = new Uppgift7();
            try
            {
                uppg7.AddFamilyMember(0);
            }
            catch(Exception e)
            {
                errMsg = e.Message;
            }
            Assert.AreEqual("Ogiltig ålder", errMsg);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTenta;

namespace TDDTentaTests
{
    [TestClass]
    public class Uppgift1Tests
    {
        Uppgift1 uppg1;
        int maximumEndYear;

        [TestInitialize]
        public void Setup()
        {
            uppg1  = new Uppgift1();
            maximumEndYear = 2100;
        }

        // Beräkna förväntat antal invånare enligt diagrammet
        // Lagt det i egen metod så att olika testfall kan återanvända uträkningen.
        private double CalcExpectedPopulation(int endYear)
        {
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

        [TestMethod]
        public void Uppg1_TestEndYearAs2016()
        {
            int endYear = 2016;
            Assert.AreEqual(CalcExpectedPopulation(endYear), uppg1.RaknaUtInvanare(endYear));
        }

        [TestMethod]
        public void Uppg1_TestEndYearAs2030()
        {
            int endYear = 2030;
            Assert.AreEqual(CalcExpectedPopulation(endYear), uppg1.RaknaUtInvanare(endYear));
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Uppg1_TestEndYearAsNegative()
        {
            uppg1.RaknaUtInvanare(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Uppg1_TestEndYearAsZero()
        {
            uppg1.RaknaUtInvanare(0);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void Uppg1_TestEndYearAsNull()
        {
            uppg1.RaknaUtInvanare(null);
        }

        [TestMethod]
        public void Uppg1_TestMaxEndYear()
        {
            uppg1.RaknaUtInvanare(maximumEndYear);
        }

        [TestMethod]
        public void Uppg1_TestMaxEndYearPlusOne()
        {
            try
            {
                uppg1.RaknaUtInvanare(maximumEndYear + 1);
            }
            catch (Exception e)
            {
                Assert.AreEqual(String.Format("År {0} är större än max tillåtna år.", maximumEndYear + 1), e.Message);
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FHR;

namespace FHR_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Bruttopreis_berechnetsichAusBettopreisUndMwst()
        {
            //Arrange
            ProduktNachschreiber P = new ProduktNachschreiber();
            P.Bruttopreis = 10.00;
            P.Mwst = 0.19;
            //Act
            double ergebniss = P.NettoPreis();

            //Assert
            Assert.AreEqual(11.90, ergebniss);
        }


        [TestMethod]
        public void Rabbatieren_senktBruttopreis()
        {
            //arrange
            ProduktNachschreiber P = new ProduktNachschreiber();
            P.Bruttopreis = 10.00;

            //act
            P.Rabbatieren(20);

            //Assert
            Assert.AreEqual(8.0, P.Bruttopreis);
        }
        [TestMethod]
        public void Rabbatien_zuHoherWertWirdIgnoriert()
        {
            //Arrange
            ProduktNachschreiber P = new ProduktNachschreiber();
            P.Bruttopreis = 10.00;

            //Act 
            P.Rabbatieren(90);

            //Assert
            Assert.AreEqual(10.00,P.Bruttopreis);
        }

    }
}

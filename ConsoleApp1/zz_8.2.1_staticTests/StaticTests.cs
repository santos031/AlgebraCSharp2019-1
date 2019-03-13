using Microsoft.VisualStudio.TestTools.UnitTesting;
using zz_8._2._1_static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._2._1_static.Tests
{
    [TestClass()]
    public class StaticTests
    {
        [TestMethod()]
        public void ZbrojTest()
        {
            Assert.AreEqual(6, Static.Zbroj(3.4, 2.6));
            //Assert.Fail();
        }

   
        [TestMethod()]
        public void KubTest()
        {
            Assert.AreEqual(8, Static.Kub(2));
        }

        [TestMethod()]
        public void UdaljenostTest()
        {
            Assert.AreEqual(2, Static.Udaljenost(0,0,0,2));
            Assert.AreNotEqual(3, Static.Udaljenost(0, 0, 0, 2));
            
            // Assert.AreEqual(2,......); 
            //na tockice upisujem svoju funkciju koja provjerava tocnost
            //npr. (int expected, int actual, string message)
        }

        [TestMethod()]
        public void FahrenheitTest()
        {
            //moguće stvaranje liste Case-ova koja ce ubacivati brojeve u asserte

            Assert.AreEqual(32, Static.Fahrenheit(0));
            Assert.AreEqual(60.8, Static.Fahrenheit(16));
            Assert.AreEqual(23, Static.Fahrenheit(-5));
            Assert.AreEqual(-508, Static.Fahrenheit(-300));
            Assert.IsTrue(Static.Fahrenheit(-150) >= -273);

            //moguće stvaranje testova i sa exceptionima (npr. TemperaturaPreniska Exception)
            //exception onda postaje nova klasa
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToString;

namespace NumbersTest
{
    [TestClass]
    public class TensConverterTest
    {
        [TestMethod]
        public void Given_Input_is_20_return_twenty()
        {
            //Given I have the int 20
            int number = 20;
            //When I pass the value in to the number sting converter
            ITensConverter tensConverter = new TensConverter();
            string text = tensConverter.Convert(number);
            //Then I get back twenty
            Assert.AreEqual("twenty", text);
        }

        [TestMethod]
        public void Given_Input_is_30_return_thirty()
        {
            //Given I have the int 30
            int number = 30;
            //When I pass the value in to the number sting converter
            ITensConverter tensConverter = new TensConverter();
            string text = tensConverter.Convert(number);
            //Then I get back thirty
            Assert.AreEqual("thirty", text);
        }

        [TestMethod]
        public void Given_Input_is_40_return_fourty()
        {
            //Given I have the int 40
            int number = 40;
            //When I pass the value in to the number sting converter
            ITensConverter tensConverter = new TensConverter();
            string text = tensConverter.Convert(number);
            //Then I get back fourty
            Assert.AreEqual("fourty", text);
        }

        [TestMethod]
        public void Given_Input_is_70_return_seventy()
        {
            //Given I have the int 70
            int number = 70;
            //When I pass the value in to the number sting converter
            ITensConverter tensConverter = new TensConverter();
            string text = tensConverter.Convert(number);
            //Then I get back seventy
            Assert.AreEqual("seventy", text);
        }

        [TestMethod]
        public void Given_Input_is_90_return_ninety()
        {
            //Given I have the int 90
            int number = 90;
            //When I pass the value in to the number sting converter
            ITensConverter tensConverter = new TensConverter();
            string text = tensConverter.Convert(number);
            //Then I get back ninety
            Assert.AreEqual("ninety", text);
        }
    }
}

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
        public void Given_Input_is_21_return_twenty_one()
        {
            //Given I have the int 21
            int number = 21;
            //When I pass the value in to the number sting converter
            ITensConverter tensConverter = new TensConverter();
            string text = tensConverter.Convert(number);
            //Then I get back twenty one
            Assert.AreEqual("twenty one", text);
        }
    }
}

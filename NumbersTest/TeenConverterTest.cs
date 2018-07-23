using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToString;

namespace NumbersTest
{
    [TestClass]
    public class TeenConverterTest
    {
        [TestMethod]
        public void Given_Input_is_11_return_eleven()
        {
            //Given I have the int 11
            int number = 11;
            //When I pass the value in to the number sting converter
            ITeenConverter teenConverter = new TeenConverter();
            string text = teenConverter.Convert(number);
            //Then I get back eleven
            Assert.AreEqual("eleven", text);
        }

        [TestMethod]
        public void Given_Input_is_12_return_twelve()
        {
            //Given I have the int 12
            int number = 12;
            //When I pass the value in to the number sting converter
            ITeenConverter teenConverter = new TeenConverter();
            string text = teenConverter.Convert(number);
            //Then I get back twelve
            Assert.AreEqual("twelve", text);
        }

        [TestMethod]
        public void Given_Input_is_13_return_thirteen()
        {
            //Given I have the int 13
            int number = 13;
            //When I pass the value in to the number sting converter
            ITeenConverter teenConverter = new TeenConverter();
            string text = teenConverter.Convert(number);
            //Then I get back thirteen
            Assert.AreEqual("thirteen", text);
        }

        [TestMethod]
        public void Given_Input_is_15_return_fifteen()
        {
            //Given I have the int 15
            int number = 15;
            //When I pass the value in to the number sting converter
            ITeenConverter teenConverter = new TeenConverter();
            string text = teenConverter.Convert(number);
            //Then I get back fifteen
            Assert.AreEqual("fifteen", text);
        }

        [TestMethod]
        public void Given_Input_is_19_return_nineteen()
        {
            //Given I have the int 19
            int number = 19;
            //When I pass the value in to the number sting converter
            ITeenConverter teenConverter = new TeenConverter();
            string text = teenConverter.Convert(number);
            //Then I get back nineteen
            Assert.AreEqual("nineteen", text);
        }
    }
}

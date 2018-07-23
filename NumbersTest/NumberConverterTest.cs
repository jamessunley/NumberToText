using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToString;

namespace NumbersTest
{
    [TestClass]
    public class NumberConverterTest
    {
        [TestMethod]
        public void Given_Number_is_1_return_string_one()
        {
            //Given I have the int 1
            int number = 1;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back one
            Assert.AreEqual("one", text);
        }

        [TestMethod]
        public void Given_Number_is_2_return_string_two()
        {
            //Given I have the int 2
            int number = 2;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back two
            Assert.AreEqual("two", text);
        }

        [TestMethod]
        public void Given_Number_is_3_return_string_three()
        {
            //Given I have the int 3
            int number = 3;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back three
            Assert.AreEqual("three", text);
        }

        [TestMethod]
        public void Given_Number_is_5_return_string_five()
        {
            //Given I have the int 5
            int number = 5;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back five
            Assert.AreEqual("five", text);
        }

        [TestMethod]
        public void Given_Number_is_10_return_string_ten()
        {
            //Given I have the int 10
            int number = 10;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back ten
            Assert.AreEqual("ten", text);
        }

        [TestMethod]
        public void Given_Number_is_11_return_string_eleven()
        {
            //Given I have the int 11
            int number = 11;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back eleven
            Assert.AreEqual("eleven", text);
        }

        [TestMethod]
        public void Given_Number_is_12_return_string_twelve()
        {
            //Given I have the int 12
            int number = 12;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back twelve
            Assert.AreEqual("twelve", text);
        }

        [TestMethod]
        public void Given_Number_is_13_return_string_thirteen()
        {
            //Given I have the int 13
            int number = 13;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back thirteen
            Assert.AreEqual("thirteen", text);
        }

        [TestMethod]
        public void Given_Number_is_15_return_string_fifteen()
        {
            //Given I have the int 15
            int number = 15;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back fifteen
            Assert.AreEqual("fifteen", text);
        }

        [TestMethod]
        public void Given_Number_is_19_return_string_nineteen()
        {
            //Given I have the int 19
            int number = 19;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back nineteen
            Assert.AreEqual("nineteen", text);
        }

        [TestMethod]
        public void Given_Number_is_20_return_string_twenty()
        {
            //Given I have the int 20
            int number = 20;
            //When I pass the value in to the number sting converter
            INumberConverter numberConverter = new NumberConverter();
            string text = numberConverter.Convert(number);
            //Then I get back twenty
            Assert.AreEqual("twenty", text);
        }
    }
}

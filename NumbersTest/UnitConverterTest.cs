using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToString;

namespace NumbersTest
{
    [TestClass]
    public class UnitConverterTest
    {
        [TestMethod]
        public void Given_Number_is_1_return_string_one()
        {
            //Given I have the int 1
            int number = 1;
            //When I pass the value in to the number sting converter
            IUnitConverter unitConverter = new UnitConverter();
            string text = unitConverter.Convert(number);
            //Then I get back one
            Assert.AreEqual("one", text);
        }

        [TestMethod]
        public void Given_Number_is_2_return_string_two()
        {
            //Given I have the int 2
            int number = 2;
            //When I pass the value in to the number sting converter
            IUnitConverter unitConverter = new UnitConverter();
            string text = unitConverter.Convert(number);
            //Then I get back two
            Assert.AreEqual("two", text);
        }

        [TestMethod]
        public void Given_Number_is_3_return_string_three()
        {
            //Given I have the int 3
            int number = 3;
            //When I pass the value in to the number sting converter
            IUnitConverter unitConverter = new UnitConverter();
            string text = unitConverter.Convert(number);
            //Then I get back three
            Assert.AreEqual("three", text);
        }

        [TestMethod]
        public void Given_Number_is_5_return_string_five()
        {
            //Given I have the int 5
            int number = 5;
            //When I pass the value in to the number sting converter
            IUnitConverter unitConverter = new UnitConverter();
            string text = unitConverter.Convert(number);
            //Then I get back five
            Assert.AreEqual("five", text);
        }

        [TestMethod]
        public void Given_Number_is_10_return_string_ten()
        {
            //Given I have the int 10
            int number = 10;
            //When I pass the value in to the number sting converter
            IUnitConverter unitConverter = new UnitConverter();
            string text = unitConverter.Convert(number);
            //Then I get back ten
            Assert.AreEqual("ten", text);
        }
    }
}

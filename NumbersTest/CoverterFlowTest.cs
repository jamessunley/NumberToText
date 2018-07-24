using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NumbersToString;

namespace NumbersTest
{
    [TestClass]
    public class CoverterFlowTest
    {
        [TestMethod]
        public void Given_input_is_1_unitconverter_called_once()
        {
            //Given I have the input 1
            int number = 1;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called once
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not called
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_2_unitconverter_called_once()
        {
            //Given I have the input 2
            int number = 2;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called once
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not called
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_10_unitconverter_called_once()
        {
            //Given I have the input 10
            int number = 10;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called once
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not called
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_11_teensconverter_called_once()
        {
            //Given I have the input 11
            int number = 11;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_15_teensconverter_called_once()
        {
            //Given I have the input 15
            int number = 15;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_19_teensconverter_called_once()
        {
            //Given I have the input 19
            int number = 19;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_20_tensconverter_called_once()
        {
            //Given I have the input 20
            int number = 20;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_21_tensconverter_called_once_and_unitsconverter_is_called_once()
        {
            //Given I have the input 21
            int number = 21;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_29_tensconverter_called_once_and_unitsconverter_is_called_once()
        {
            //Given I have the input 29
            int number = 29;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_30_tensconverter_called_once()
        {
            //Given I have the input 30
            int number = 30;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_55_tensconverter_called_once_and_unitsconverter_is_called_once()
        {
            //Given I have the input 55
            int number = 55;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_77_tensconverter_called_once_and_unitsconverter_is_called_once()
        {
            //Given I have the input 77
            int number = 77;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_90_tensconverter_called_once()
        {
            //Given I have the input 90
            int number = 90;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_99_tensconverter_called_once_and_unitsconverter_is_called_once()
        {
            //Given I have the input 99
            int number = 99;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
            //And I will verify that onehundredConverter is not called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void Given_input_is_100_onehundredconverter_is_called_once()
        {
            //Given I have the input 100
            int number = 100;
            //And I have a unitconverter object
            Mock<IUnitConverter> mock = new Mock<IUnitConverter>();
            //And I have a teensconverter object
            Mock<ITeensConverter> teenmock = new Mock<ITeensConverter>();
            //And I have a tensconverter object
            Mock<ITensConverter> tenmock = new Mock<ITensConverter>();
            //And I have a onehundredconverter object
            Mock<IOneHundredConverter> onehundredmock = new Mock<IOneHundredConverter>();
            //When I call converterFlow.calculate
            IConverterFlow converterFlow = new ConverterFlow(mock.Object, teenmock.Object, tenmock.Object, onehundredmock.Object);
            converterFlow.Convert(number);
            //Then I will verify that unitconverter is called never
            mock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that teensConverter is not once
            teenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that tensConverter is not called
            tenmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Never);
            //And I will verify that onehundredConverter is called
            onehundredmock.Verify(m => m.Convert(It.IsAny<int>()), Times.Once);
        }

    }
}

using Moq;
using System;

namespace Quantify.UnitTests.TestQuantities
{
    public class DoubleValueStringUnitQuantityBuilder
    {
        private double value = 42;
        private string unit = "SomeUnit";
        public Mock<UnitConversionDataRepository<string>> UnitRepositoryMock { get; } = new Mock<UnitConversionDataRepository<string>>();
        public Mock<ValueCalculator<double>> ValueCalculatorMock { get; } = new Mock<ValueCalculator<double>>();
        public Mock<IValueConverter<double, string>> ValueConverterMock { get; } = new Mock<IValueConverter<double, string>>();

        public static DoubleValueStringUnitQuantityBuilder NewInstance()
        {
            return new DoubleValueStringUnitQuantityBuilder();
        }

        public DoubleValueStringUnitQuantityBuilder WithValue(double value)
        {
            this.value = value;
            return this;
        }

        public DoubleValueStringUnitQuantityBuilder WithUnit(string unit)
        {
            this.unit = unit;
            return this;
        }

        public DoubleValueStringUnitQuantityBuilder MockUnitRepository(Action<Mock<UnitConversionDataRepository<string>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(UnitRepositoryMock);
            return this;
        }

        public DoubleValueStringUnitQuantityBuilder MockValueCalculator(Action<Mock<ValueCalculator<double>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(ValueCalculatorMock);
            return this;
        }

        public DoubleValueStringUnitQuantityBuilder MockValueConverter(Action<Mock<IValueConverter<double, string>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(ValueConverterMock);
            return this;
        }

        public DoubleValueStringUnitQuantity Build()
        {
            return new DoubleValueStringUnitQuantity(value, unit, UnitRepositoryMock.Object, ValueCalculatorMock.Object, ValueConverterMock.Object);
        }

        public Mock<DoubleValueStringUnitQuantity> BuildMock(bool callBase = false)
        {
            return new Mock<DoubleValueStringUnitQuantity>(value, unit, UnitRepositoryMock.Object, ValueCalculatorMock.Object, ValueConverterMock.Object) { CallBase = callBase };
        }
    }
}
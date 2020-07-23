using Moq;
using System;

namespace Quantify.UnitTests.Quantity.Assets
{
    /*internal class EnumTestQuantityBuilder
    {
        private double value = 42;
        private TestUnit unit = TestUnit.Centimetre;

        public readonly Mock<QuantityFactory<double, TestUnit, EnumTestQuantity>> quantityFactoryMock = new Mock<QuantityFactory<double, TestUnit, EnumTestQuantity>>();
        public readonly Mock<UnitRepository<double, TestUnit>> unitRepositoryMock = new Mock<UnitRepository<double, TestUnit>>();
        public readonly Mock<ValueCalculator<double>> valueCalculatorMock = new Mock<ValueCalculator<double>>();
        public readonly Mock<ValueConverter<double, TestUnit>> valueConverterMock = new Mock<ValueConverter<double, TestUnit>>();

        private EnumTestQuantityBuilder() { }

        public static EnumTestQuantityBuilder Instance()
        {
            return new EnumTestQuantityBuilder();
        }

        public EnumTestQuantityBuilder WithValue(double value)
        {
            this.value = value;
            return this;
        }

        public EnumTestQuantityBuilder WithUnit(TestUnit unit)
        {
            this.unit = unit;
            return this;
        }

        public EnumTestQuantityBuilder MockQuantityFactory(Action<Mock<QuantityFactory<double, TestUnit, EnumTestQuantity>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(quantityFactoryMock);

            return this;
        }

        public EnumTestQuantityBuilder MockUnitRepository(Action<Mock<UnitRepository<double, TestUnit>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(unitRepositoryMock);

            return this;
        }

        public EnumTestQuantityBuilder MockValueCalculator(Action<Mock<ValueCalculator<double>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(valueCalculatorMock);

            return this;
        }

        public EnumTestQuantityBuilder MockValueConverter(Action<Mock<ValueConverter<double, TestUnit>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(valueConverterMock);

            return this;
        }

        public EnumTestQuantity Build()
        {
            return new EnumTestQuantity(value, unit, quantityFactoryMock.Object, unitRepositoryMock.Object, valueCalculatorMock.Object, valueConverterMock.Object);
        }
    }*/
}
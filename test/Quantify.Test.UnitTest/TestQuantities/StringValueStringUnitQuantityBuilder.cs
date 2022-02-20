﻿using Moq;
using System;

namespace Quantify.Test.UnitTest.TestQuantities
{
    public class StringValueStringUnitQuantityBuilder
    {
        private string value = "SomeValue";
        private string unit = "SomeUnit";
        public Mock<UnitRepository<string>> UnitRepositoryMock { get; } = new Mock<UnitRepository<string>>();
        public Mock<ValueCalculator<string>> ValueCalculatorMock { get; } = new Mock<ValueCalculator<string>>();
        public Mock<ValueConverter<string, string>> ValueConverterMock { get; } = new Mock<ValueConverter<string, string>>();

        private StringValueStringUnitQuantityBuilder()
        {
        }

        public static StringValueStringUnitQuantityBuilder NewInstance()
        {
            return new StringValueStringUnitQuantityBuilder();
        }

        public StringValueStringUnitQuantityBuilder WithValue(string value)
        {
            this.value = value;
            return this;
        }

        public StringValueStringUnitQuantityBuilder WithUnit(string unit)
        {
            this.unit = unit;
            return this;
        }

        public StringValueStringUnitQuantityBuilder MockUnitRepository(Action<Mock<UnitRepository<string>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(UnitRepositoryMock);
            return this;
        }

        public StringValueStringUnitQuantityBuilder MockValueCalculator(Action<Mock<ValueCalculator<string>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(ValueCalculatorMock);
            return this;
        }

        public StringValueStringUnitQuantityBuilder MockValueConverter(Action<Mock<ValueConverter<string, string>>> mockCallback)
        {
            if (mockCallback == null)
                throw new ArgumentNullException(nameof(mockCallback));

            mockCallback(ValueConverterMock);
            return this;
        }

        public StringValueStringUnitQuantity Build()
        {
            return new StringValueStringUnitQuantity(value, unit, UnitRepositoryMock.Object, ValueCalculatorMock.Object, ValueConverterMock.Object);
        }

        public Mock<StringValueStringUnitQuantity> BuildMock(bool callBase = false)
        {
            return new Mock<StringValueStringUnitQuantity>(value, unit, UnitRepositoryMock.Object, ValueCalculatorMock.Object, ValueConverterMock.Object) { CallBase = callBase };
        }
    }
}
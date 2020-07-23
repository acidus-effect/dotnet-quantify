using Moq;
using System;

namespace Quantify.UnitTests.Converters
{
    internal class ValueConverterBuilder<TValue, TUnit>
    {
        public Mock<UnitRepository<TValue, TUnit>> UnitRepositoryMock { get; } = new Mock<UnitRepository<TValue, TUnit>>();
        public Mock<ValueCalculator<TValue>> ValueCalculatorMock { get; } = new Mock<ValueCalculator<TValue>>();

        private ValueConverterBuilder() { }

        public static ValueConverterBuilder<TValue, TUnit> NewInstance()
        {
            return new ValueConverterBuilder<TValue, TUnit>();
        }

        public ValueConverterBuilder<TValue, TUnit> MockUnitRepository(Action<Mock<UnitRepository<TValue, TUnit>>> mockingCallback)
        {
            if (mockingCallback == null)
                throw new ArgumentNullException(nameof(mockingCallback));

            mockingCallback(UnitRepositoryMock);
            return this;
        }

        public ValueConverterBuilder<TValue, TUnit> MockValueCalculator(Action<Mock<ValueCalculator<TValue>>> mockingCallback)
        {
            if (mockingCallback == null)
                throw new ArgumentNullException(nameof(mockingCallback));

            mockingCallback(ValueCalculatorMock);
            return this;
        }

        public ValueConverter<TValue, TUnit> Build()
        {
            return new ValueConverter<TValue, TUnit>(UnitRepositoryMock.Object, ValueCalculatorMock.Object);
        }
    }
}
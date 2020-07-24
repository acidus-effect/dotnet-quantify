using Moq;
using System.Collections.Generic;

namespace Quantify.IntegrationTests.Quantity.Assets
{
    internal class TestData
    {
        public static string Millimetre { get; } = "Millimetre";
        public static string Centimetre { get; } = "Centimetre";
        public static string Decimetre { get; } = "Decimetre";
        public static string Metre { get; } = "Metre";
        public static string Decametre { get; } = "Decametre";
        public static string Hectometre { get; } = "Hectometre";
        public static string Kilometre { get; } = "Kilometre";

        private static readonly double millimetreUnitValue = 0.001;
        private static readonly double centimetreUnitValue = 0.01;
        private static readonly double decimetreUnitValue = 0.1;
        private static readonly double metreUnitValue = 1;
        private static readonly double decametreUnitValue = 10;
        private static readonly double hectometreUnitValue = 100;
        private static readonly double kilometreUnitValue = 1000;

        private static readonly IDictionary<string, double> unitDataDictionary = new Dictionary<string, double>()
        {
            { Millimetre, millimetreUnitValue },
            { Centimetre, centimetreUnitValue },
            { Decimetre, decimetreUnitValue },
            { Metre, metreUnitValue },
            { Decametre, decametreUnitValue },
            { Hectometre, hectometreUnitValue },
            { Kilometre, kilometreUnitValue }
        };

        public static UnitRepository<double, string> CreateUnitRepository()
        {
            var unitRepositoryMock = new Mock<UnitRepository<double, string>>();

            foreach(var unitData in unitDataDictionary)
            {
                unitRepositoryMock.Setup(unitRepository => unitRepository.GetUnit(It.Is<string>(unit => unit == unitData.Key))).Returns(CreateUnitData(unitData.Key, unitData.Value));
            }

            return unitRepositoryMock.Object;
        }

        private static UnitData<double, string> CreateUnitData(string unit, double value)
        {
            var unitDataMock = new Mock<UnitData<double, string>>();
            unitDataMock.Setup(unitData => unitData.Unit).Returns(unit);
            unitDataMock.Setup(unitData => unitData.Value).Returns(value);
            return unitDataMock.Object;
        }
    }
}
using Moq;
using System.Collections.Generic;

namespace Quantify.IntegrationTests.Quantity.Assets
{
    public class TestData
    {
        public const string Millimetre = "Millimetre";
        public const string Centimetre = "Centimetre";
        public const string Decimetre = "Decimetre";
        public const string Metre = "Metre";
        public const string Decametre = "Decametre";
        public const string Hectometre = "Hectometre";
        public const string Kilometre = "Kilometre";

        public const double MillimetreUnitValue = 0.001;
        public const double CentimetreUnitValue = 0.01;
        public const double DecimetreUnitValue = 0.1;
        public const double MetreUnitValue = 1;
        public const double DecametreUnitValue = 10;
        public const double HectometreUnitValue = 100;
        public const double KilometreUnitValue = 1000;

        private static readonly IDictionary<string, double> unitDataDictionary = new Dictionary<string, double>()
        {
            { Millimetre, MillimetreUnitValue },
            { Centimetre, CentimetreUnitValue },
            { Decimetre, DecimetreUnitValue },
            { Metre, MetreUnitValue },
            { Decametre, DecametreUnitValue },
            { Hectometre, HectometreUnitValue },
            { Kilometre, KilometreUnitValue }
        };

        public static UnitRepository<string> CreateUnitRepository()
        {
            var unitRepositoryMock = new Mock<UnitRepository<string>>();

            foreach (var unitData in unitDataDictionary)
            {
                unitRepositoryMock.Setup(unitRepository => unitRepository.GetUnitValueInBaseUnits(It.Is<string>(unit => unit == unitData.Key))).Returns(unitData.Value);
            }

            return unitRepositoryMock.Object;
        }
    }
}
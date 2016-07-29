using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Rick.Tests
{
    [TestFixture]
    public class OhmValueCalculatorTests
    {
//        [TestCase("Black", "", "", "", 0)]
        [TestCase("Red", "Black", "Black", "Brown", 20)]
        public void CalculateOhmValue_SpecifiedBands_ReturnsExpectedValue(string bandAColor, string bandBColor,
            string bandCColor, string bandDColor, int expectedResistance)
        {
            var sut = (IOhmValueCalculator) new OhmValueCalculator();

            var actualValue = sut.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            Assert.That(actualValue, Is.EqualTo(expectedResistance));
        }
    }
}

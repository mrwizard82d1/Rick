using NUnit.Framework;

namespace Rick.Tests
{
    /// <summary>
    /// Defines the unit tests for the <see cref="OhmValueCalculator"/> class.
    /// </summary>
    [TestFixture]
    public class OhmValueCalculatorTests
    {
        [TestCase("Black", "", "", "", 0)]
        [TestCase("Red", "Black", "Black", "Brown", 20)]
        public void CalculateOhmValue_SpecifiedBands_ReturnsExpectedValue(string bandAColor, string bandBColor,
            string bandCColor, string bandDColor, int expectedResistance)
        {
            var sut = (IOhmValueCalculator) new OhmValueCalculator();

            var actualValue = sut.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            Assert.That(actualValue, Is.EqualTo(expectedResistance));
        }

        [TestCase]
        public void Resistance_TooLarge_ThrowsResistorExceptionWithMessage()
        {
            var sut = (IOhmValueCalculator) new OhmValueCalculator();

            Assert.That(() => sut.CalculateOhmValue("red", "White", "whitE", string.Empty),
                Throws.InstanceOf<ResistorException>().With.Message.EqualTo("Resistance '29000000000' too large."));
        }

    }
}

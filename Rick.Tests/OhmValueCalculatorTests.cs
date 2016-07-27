using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Rick.Tests
{
    [TestFixture]
    public class OhmValueCalculatorTests
    {
        [TestCase]
        public void CalculateOhmValue_RedBlackBlackBrown_ReturnsValue()
        {
            var sut = (IOhmValueCalculator) new OhmValueCalculator();

            var actualValue = sut.CalculateOhmValue("Red", "Black", "Black", "Brown");
            Assert.That(actualValue, Is.EqualTo(20));
        }
    }
}

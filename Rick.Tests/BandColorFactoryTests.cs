using System;
using NUnit.Framework;

namespace Rick.Tests
{
    [TestFixture]
    public class BandColorFactoryTests
    {
        [TestCase("Black", BandColor.Black)]
        [TestCase("Brown", BandColor.Brown)]
        [TestCase("Red", BandColor.Red)]
        [TestCase("Orange", BandColor.Orange)]
        [TestCase("Yellow", BandColor.Yellow)]
        [TestCase("Green", BandColor.Green)]
        [TestCase("blue", BandColor.Blue)]
        [TestCase("Violet", BandColor.Violet)]
        [TestCase("Gray", BandColor.Gray)]
        [TestCase("White", BandColor.White)]
        [TestCase("Gold", BandColor.Gold)]
        [TestCase("silveR", BandColor.Silver)]
        [TestCase("None", BandColor.None)]
        public void FromText_ValidText_ReturnsExpectedBandColor(string validText, BandColor expectedColor)
        {
            Assert.That(BandColorFactory.FromText(validText), Is.EqualTo(expectedColor));
        }

        [TestCase("")]
        [TestCase("\t")]
        public void FromText_EmptyString_ReturnsBandColorNone(string emptyText)
        {
            Assert.That(BandColorFactory.FromText(emptyText), Is.EqualTo(BandColor.None));
        }

        [TestCase]
        public void FromText_Null_ThrowsBandColorExceptionWithMessage()
        {
            Assert.That(() => BandColorFactory.FromText(null),
                Throws.InstanceOf<BandColorConversionException>()
                      .With.Message.EqualTo("Cannot convert `null` value to `BandColor`."));
        }
    }
}

using System.Linq;
using NUnit.Framework;
using RickWeb.Models;

namespace RickWeb.Tests
{
    [TestFixture]
    public class ResistorViewModelTests
    {
        [TestCase]
        public void BandAColors_None_HaveColors()
        {
            var sut = new ResistorViewModel();

            Assert.That(sut.BandAColors.Select(bac => bac.Text),
                Is.EqualTo(new[]
                {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"}));
        }

        [TestCase]
        public void BandBColors_None_HaveColors()
        {
            var sut = new ResistorViewModel();

            Assert.That(sut.BandBColors.Select(bac => bac.Text),
                Is.EqualTo(new[]
                {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"}));
        }

        [TestCase]
        public void BandCColors_None_HaveColors()
        {
            var sut = new ResistorViewModel();

            Assert.That(sut.BandCColors.Select(bac => bac.Text).ToList(),
                Is.EqualTo(new[]
                {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet"}));
        }

        [TestCase("Black", "Black", "Black", "ohms")]
        [TestCase("Black", "Brown", "Black", "ohm")]
        [TestCase("Black", "Red", "Black", "ohms")]
        public void ResistanceText_SpecifiedABCBandColors_EndsWithWord(string bandAColor, string bandBColor,
            string bandCColor, string endsWithWord)
        {
            var sut = new ResistorViewModel
            {
                BandAColor = bandAColor,
                BandBColor = bandBColor,
                BandCColor = bandCColor,
                BandDColor = "None",
            };

            Assert.That(sut.ResistanceText, Does.EndWith(endsWithWord));
        }

        [TestCase("Black", "Black", "Black", 0)]
        [TestCase("Black", "Brown", "Black", 1)]
        [TestCase("Black", "Red", "Black", 2)]
        [TestCase("Red", "White", "Brown", 290)]
        public void Resistance_SpecifiedABCBandColors_ReturnsValue(string bandAColor, string bandBColor,
            string bandCColor, int expectedValue)
        {
            var sut = new ResistorViewModel
            {
                BandAColor = bandAColor,
                BandBColor = bandBColor,
                BandCColor = bandCColor,
                BandDColor = "None",
            };

            Assert.That(sut.Resistance, Is.EqualTo(expectedValue));
        }
    }
}

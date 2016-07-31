using System;
using System.Linq;
using System.Web.Mvc;
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

            Assert.That(sut.BandCColors.Select(bac => bac.Text),
                Is.EqualTo(new[]
                {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver"}));
        }

    }
}

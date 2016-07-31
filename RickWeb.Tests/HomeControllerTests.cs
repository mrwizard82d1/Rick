using System.Web.Mvc;
using NUnit.Framework;
using Rick;
using RickWeb.Controllers;
using RickWeb.Models;

namespace RickWeb.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [TestCase]
        public void IndexActionReturnsIndexViewWithCorrectModel()
        {
            var sut = new HomeController();

            var actualControllerResult = (ViewResult) sut.Index();
            Assert.That(((ResistorViewModel) actualControllerResult.Model).BandAColor, Is.EqualTo(BandColor.Black.ToString()));
        }
    }
}

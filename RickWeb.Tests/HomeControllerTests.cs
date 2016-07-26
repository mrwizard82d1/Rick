using System.Web.Mvc;
using NUnit.Framework;
using RickWeb.Controllers;

namespace RickWeb.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [TestCase]
        public void IndexActionReturnsIndexViewWithCorrectName()
        {
            var sut = new HomeController();

            var actualControllerResult = (ViewResult) sut.Index();
            Assert.That(actualControllerResult.ViewName, Is.EqualTo("Index"));
        }
    }
}

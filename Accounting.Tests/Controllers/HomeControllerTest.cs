using Accounting.Controllers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Accounting.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var controller = new HomeController();
            var view = controller.Index();
            Assert.IsNotNull(view,"View was NULL");
        }
    }
}

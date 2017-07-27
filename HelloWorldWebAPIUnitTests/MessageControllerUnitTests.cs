using HelloWorldServiceLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using HelloWorldWebAPI.Controllers;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace HelloWorldWebAPIUnitTests
{
    [TestClass]
    public class MessageControllerUnitTests
    {
        [TestMethod, TestCategory("Message Controller")]
        public void GetMessage_ReturnsHelloWorld()
        {
            var service = new Mock<IMessageProvider>();
            service.Setup(s => s.GetMessage()).Returns("Hello World");

            var controller = new MessageController(service.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            IHttpActionResult result = controller.GetMessage();
            var contentResult = result as OkNegotiatedContentResult<string>;

            var data = (contentResult.Content as string);
            Assert.AreEqual("Hello World", data);
        }
    }
}

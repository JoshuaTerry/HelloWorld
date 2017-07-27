using HelloWorldServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HelloWorldWebAPI.Controllers
{
    [RoutePrefix("api/Account")]
    public class MessageController : ApiController
    {
        private IMessageProvider provider;
        // Constructor for IoC and Unit Tests
        public MessageController(IMessageProvider provider)
        {
            this.provider = provider;
        }

        public MessageController()
        {
            provider = new StaticMessageProvider();
        }

        [HttpGet]
        public IHttpActionResult GetMessage()
        {
            return Ok("Hello World");
        }
    }
}
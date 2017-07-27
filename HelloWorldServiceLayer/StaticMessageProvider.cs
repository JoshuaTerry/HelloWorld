using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldServiceLayer
{
    public class StaticMessageProvider : IMessageProvider
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}

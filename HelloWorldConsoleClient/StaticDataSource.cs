using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleClient
{
    public class StaticDataSource : IDataSource
    {
        public string GetMessage()
        {
            return "Hello World";
        }         
    }
}

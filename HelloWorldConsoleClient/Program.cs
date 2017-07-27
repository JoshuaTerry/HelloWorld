using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // You'd set this up to pull either from app config or using IoC to determin which "Data Source" to use.
            var source = new StaticDataSource();
            Console.WriteLine(source.GetMessage());
        }
    }
}

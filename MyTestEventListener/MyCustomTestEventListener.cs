using NUnit.Engine;
using NUnit.Engine.Extensibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace MyTestEventListener
{
    [Extension(EngineVersion = "3.8")]
    public class MyCustomTestEventListener : ITestEventListener
    {
        public void OnTestEvent(string report)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(report);

            //simulate Slowness and give a concurrent test thread time to run away...
            //Console.WriteLine($"SH: MyCustomTestEventListener: {Process.GetCurrentProcess().Id} Thread: {Environment.CurrentManagedThreadId}");

            if (report.StartsWith("<start-test"))
            {
                Thread.Sleep(300);
                //< start - test id = "0-1001" parentId = "0-1000" name = "MyFirstTest" fullname = "MyUnitTests.SomeTests.MyFirstTest" type = "TestMethod" />
                Console.WriteLine($"EventListener: Test case started : <{doc.DocumentElement.GetAttribute("name")}> ({DateTime.Now.ToString("hh:mm:ss.fff")})");
                //Debugger.Launch();
            }
            else if (report.StartsWith("<test-case"))
            {
                Console.WriteLine($"EventListener: Test case finished: <{doc.DocumentElement.GetAttribute("name")}> ({DateTime.Now.ToString("hh:mm:ss.fff")})");
                Console.WriteLine();
            }
        }
    }
}

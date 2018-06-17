using MyFrameworkDriver.ModifiedNUnit3ConsoleFiles;
using NUnit.Engine.Drivers;
using NUnit.Engine.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MyFrameworkDriver
{
    [Extension]
    public class MyFrameworkDriverFactory : IDriverFactory
    {
        private const string NUNIT_FRAMEWORK = "nunit.framework";

        public IFrameworkDriver GetDriver(AppDomain domain, AssemblyName reference)
        {
            return new MyCustomNUnit3FrameworkDriver(domain);
            //return new NUnit3FrameworkDriver(domain);
        }

        public bool IsSupportedTestFramework(AssemblyName reference)
        {
            return NUNIT_FRAMEWORK.Equals(reference.Name, StringComparison.OrdinalIgnoreCase) && reference.Version.Major == 3;
        }
    }
}

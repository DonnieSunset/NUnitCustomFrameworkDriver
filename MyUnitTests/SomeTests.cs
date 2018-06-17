using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTests
{
    //Console.WriteLine($"SH: Process: {Process.GetCurrentProcess().Id} Thread: {Environment.CurrentManagedThreadId}");

    [TestFixture]
    public class SomeTests
    {
        [Test]
        public void MyTest_01()
        {
            //Console.WriteLine($"SH: TestFixture: {Process.GetCurrentProcess().Id} Thread: {Environment.CurrentManagedThreadId}");
            Console.WriteLine($"\tTest Fixture: MyTest_01 ({DateTime.Now.ToString("hh:mm:ss.fff")})");
        }

        [Test]
        public void MyTest_02()
        {
            //Console.WriteLine($"SH: TestFixture: {Process.GetCurrentProcess().Id} Thread: {Environment.CurrentManagedThreadId}");
            Console.WriteLine($"\tTest Fixture: MyTest_02 ({DateTime.Now.ToString("hh:mm:ss.fff")})");
        }

        [Test]
        public void MyTest_03()
        {
            //Console.WriteLine($"SH: TestFixture: {Process.GetCurrentProcess().Id} Thread: {Environment.CurrentManagedThreadId}");
            Console.WriteLine($"\tTest Fixture: MyTest_03 ({DateTime.Now.ToString("hh:mm:ss.fff")})");
        }

        [Test]
        public void MyTest_04()
        {
            //Console.WriteLine($"SH: TestFixture: {Process.GetCurrentProcess().Id} Thread: {Environment.CurrentManagedThreadId}");
            Console.WriteLine($"\tTest Fixture: MyTest_04 ({DateTime.Now.ToString("hh:mm:ss.fff")})");
        }

        [Test]
        public void MyTest_05()
        {
            //Console.WriteLine($"SH: TestFixture: {Process.GetCurrentProcess().Id} Thread: {Environment.CurrentManagedThreadId}");
            Console.WriteLine($"\tTest Fixture: MyTest_05 ({DateTime.Now.ToString("hh:mm:ss.fff")})");
        }
    }
}

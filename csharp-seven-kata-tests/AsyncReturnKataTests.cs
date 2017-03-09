using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_seven_kata;
using System.Threading.Tasks;
using System.Diagnostics;

namespace csharp_seven_kata_tests
{
    [TestClass]
    public class AsyncReturnKataTests
    {
        [TestMethod]
        public async Task Validate_AsyncReturn()
        {
            var asyncReturnKata = new AsyncReturnKata();

            var sw = new Stopwatch();

            sw.Start();
            var result = await asyncReturnKata.ProcessWidget(1);
            sw.Stop();

            Debug.WriteLine($"Widget processed in {sw.ElapsedMilliseconds}ms");
            Assert.AreEqual(result, "Widget processed");
        }
    }
}

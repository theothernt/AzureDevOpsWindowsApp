using AnotherApp.WPF;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnotherApp.Tests
{
    // https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
    [TestClass]
    public class PrimeServiceTests
    {
        private readonly PrimeService _primeService;

        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}

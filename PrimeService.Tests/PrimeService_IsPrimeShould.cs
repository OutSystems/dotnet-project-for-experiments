using Prime.Services;
using Xunit;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {

            var primeService = new PrimeService();
            var result = primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

    }
}

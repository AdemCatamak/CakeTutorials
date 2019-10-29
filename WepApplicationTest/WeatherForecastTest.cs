using WebApplication;
using Xunit;

namespace WepApplicationTest
{
    public class WeatherForecastTest
    {
        private readonly WeatherForecast _sut;

        public WeatherForecastTest()
        {
            _sut = new WeatherForecast();
        }

        [Fact]
        public void WhenGetCalled_ResponseShouldBeOk()
        {
            _sut.TemperatureC = 0;
            int fahrenheit = _sut.TemperatureF;

            Assert.Equal(32, fahrenheit);
        }
    }
}
using Heidelberg.Controllers;

namespace Test
{
    public class WeatherForecastControllerTest
    {
        [Test]
        public async Task TestGetWeatherForecastShouldPass()
        {
            //Arrange
            var controller = new WeatherForecastController();

            //Act
            var result = await controller.Get("tokyo");

            // Assert
            Assert.That(result.Cod, Is.EqualTo(200));
        }

        [Test]
        public async Task TestGetWeatherForecastShouldThrowError()
        {
            //Arrange
            var controller = new WeatherForecastController();

            //Act and Assert
            Assert.ThrowsAsync<HttpRequestException>(async () => await controller.Get("t"));
        }
    }
}
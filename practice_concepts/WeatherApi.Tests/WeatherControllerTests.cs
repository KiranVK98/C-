using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using WeatherApi.Controllers;
using Microsoft.AspNetCore.Mvc;

public class WeatherControllerTests
{
    [Fact]
    public async Task GetWeather_Returns_OkResult_When_ApiResponseIsSuccessful()
    {
        // Arrange
        var mockHttpMessageHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);

        // Corrected: Use ItExpr instead of It for protected methods
        mockHttpMessageHandler
            .Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),  // Use ItExpr for protected methods
                ItExpr.IsAny<CancellationToken>()    // Use ItExpr for protected methods
            )
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"weather\":[{\"description\":\"clear sky\"}],\"main\":{\"temp\":22.5}}")
            });

        var client = new HttpClient(mockHttpMessageHandler.Object);
        var controller = new WeatherController(client);

        // Act
        var result = await controller.GetWeather("London");

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(200, okResult.StatusCode);
        Assert.NotNull(okResult.Value);
    }

    [Fact]
    public async Task GetWeather_Returns_BadRequest_When_ApiResponseFails()
    {
        // Arrange
        var mockHttpMessageHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);

        // Corrected: Use ItExpr instead of It for protected methods
        mockHttpMessageHandler
            .Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),  // Use ItExpr for protected methods
                ItExpr.IsAny<CancellationToken>()    // Use ItExpr for protected methods
            )
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.BadRequest
            });

        var client = new HttpClient(mockHttpMessageHandler.Object);
        var controller = new WeatherController(client);

        // Act
        var result = await controller.GetWeather("InvalidCity");

        // Assert
        var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal(400, badRequestResult.StatusCode);
    }
}

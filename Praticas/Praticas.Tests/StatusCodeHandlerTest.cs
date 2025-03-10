namespace Praticas.Tests
{
    public class StatusCodeHandlerTest
    {
        private readonly StatusCodeProcessor _processor;

        public StatusCodeHandlerTest()
        {
            _processor = new StatusCodeProcessor();
        }

        [Fact]
        public void WhenStatusCodeOk_ShouldReturnSuccess()
        {
            //Arrange
            var statusCode = HttpStatusCode.OK;
    
            //Act
            var result = _processor.Process(statusCode);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void WhenStatusCodeBadRequest_ShouldReturnError()
        {
            //Arrange
            var statusCode = HttpStatusCode.BadRequest;
            var expectedResult = new ErrorMessageBuilder().WithBadRequest().Build();

            //Act
            var result = _processor.Process(statusCode);

            //Assert
            Assert.NotNull(result);
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void WhenStatusCodeNotFound_ShouldReturnError()
        {
            //Arrange
            var statusCode = HttpStatusCode.NotFound;
            var expectedResult = new ErrorMessageBuilder().WithNotFound().Build();

            //Act
            var result = _processor.Process(statusCode);

            //Assert
            Assert.NotNull(result);
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void WhenStatusCodeUnprocessableEntity_ShouldReturnError()
        {
            //Arrange
            var statusCode = HttpStatusCode.UnprocessableEntity;
            var expectedResult = new ErrorMessageBuilder().WithUnprocessableEntity().Build();

            //Act
            var result = _processor.Process(statusCode);

            //Assert
            Assert.NotNull(result);
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void WhenStatusCodeInternalServerError_ShouldReturnError()
        {
            //Arrange
            var statusCode = HttpStatusCode.InternalServerError;
            var expectedResult = new ErrorMessageBuilder().WithInternalServerError().Build();

            //Act
            var result = _processor.Process(statusCode);

            //Assert
            Assert.NotNull(result);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
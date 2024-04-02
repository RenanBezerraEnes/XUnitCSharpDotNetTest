using FluentAssertions;
using XUnitCSharpDotNetTest.Ping;

namespace XUnitCSharpDotNetTest.UnitTest.PingTests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;

        public NetworkServiceTests()
        {
            _pingService = new NetworkService();
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {

            var result = _pingService.SendPing();

            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("SUCCESS: Ping Sent");
            result.Should().Contain("SUCCESS", Exactly.Once());
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeOut_ReturnInt(int a, int b, int expected)
        {
            var pingService = new NetworkService();

            var result = pingService.PingTimeOut(a, b);

            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-10000, 0);
        }
    }
};
using HB.Rover.Domain.Enums;
using HB.Rover.Domain.RouterManagement;
using HB.Rover.Domain.RouterManagement.Routers;
using Xunit;

namespace HB.Rover.Domain.Test.RouterManagement.Routers
{
    public class NorthRouterTest
    {
        private Position _position;
        private IRouter _router;

        public NorthRouterTest()
        {
            _position = new Position(0, 0, Orientation.East);
            _router = new NorthRouter();
        }

        [Fact]
        public void SetToOrientation_When_Direction_Is_Left_Expected_West()
        {
            _router.SetToOrientation(_position, Direction.Left);

            Assert.Equal(Orientation.West, _position.Orienation);
        }

        [Fact]
        public void SetToOrientation_When_Direction_Is_Right_Expected_East()
        {
            _router.SetToOrientation(_position, Direction.Right);

            Assert.Equal(Orientation.East, _position.Orienation);
        }
    }
}

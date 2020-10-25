using HB.Rover.Domain.Enums;
using HB.Rover.Domain.RouterManagement;
using HB.Rover.Domain.RouterManagement.Routers;
using Xunit;

namespace HB.Rover.Domain.Test.RouterManagement.Routers
{
    public class SouthRouterTest
    {
        private Position _position;
        private IRouter _router;

        public SouthRouterTest()
        {
            _position = new Position(0, 0, Orientation.East);
            _router = new SouthRouter();
        }

        [Fact]
        public void SetToOrientation_When_Direction_Is_Left_Expected_East()
        {
            _router.SetToOrientation(_position, Direction.Left);

            Assert.Equal(Orientation.East, _position.Orienation);
        }

        [Fact]
        public void SetToOrientation_When_Direction_Is_Right_Expected_West()
        {
            _router.SetToOrientation(_position, Direction.Right);

            Assert.Equal(Orientation.West, _position.Orienation);
        }
    }
}

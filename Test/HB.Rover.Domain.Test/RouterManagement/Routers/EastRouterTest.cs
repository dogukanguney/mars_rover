using HB.Rover.Domain.Enums;
using HB.Rover.Domain.RouterManagement;
using HB.Rover.Domain.RouterManagement.Routers;
using Xunit;

namespace HB.Rover.Domain.Test.RouterManagement.Routers
{
    public class EastRouterTest
    {
        private Position _position;
        private IRouter _router;

        public EastRouterTest()
        {
            _position = new Position(0, 0, Orientation.East);
            _router = new EastRouter();
        }

        [Fact]
        public void SetToOrientation_When_Direction_Is_Left_Expected_North()
        {
            _router.SetToOrientation(_position, Direction.Left);

            Assert.Equal(Orientation.North, _position.Orienation);
        }

        [Fact]
        public void SetToOrientation_When_Direction_Is_Right_Expected_South()
        {
            _router.SetToOrientation(_position, Direction.Right);

            Assert.Equal(Orientation.South, _position.Orienation);
        }
    }
}

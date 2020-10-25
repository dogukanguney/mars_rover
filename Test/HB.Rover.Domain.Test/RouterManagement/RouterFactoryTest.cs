using HB.Rover.Domain.Enums;
using HB.Rover.Domain.RouterManagement;
using HB.Rover.Domain.RouterManagement.Routers;
using Xunit;

namespace HB.Rover.Domain.Test.RouterManagement
{
    public class RouterFactoryTest
    {
        private IRouterFactory _routerFactory;

        public RouterFactoryTest()
        {
            _routerFactory = new RouterFactory();
        }

        [Fact]
        public void Create_East_When_Position_Is_East()
        {
            IRouter router = _routerFactory.Create(new Position(0, 0, Orientation.East));

            Assert.IsType<EastRouter>(router);
        }

        [Fact]
        public void Create_West_When_Position_Is_West()
        {
            IRouter router = _routerFactory.Create(new Position(0, 0, Orientation.West));

            Assert.IsType<WestRouter>(router);
        }

        [Fact]
        public void Create_North_When_Position_Is_North()
        {
            IRouter router = _routerFactory.Create(new Position(0, 0, Orientation.North));

            Assert.IsType<NorthRouter>(router);
        }

        [Fact]
        public void Create_South_When_Position_Is_South()
        {
            IRouter router = _routerFactory.Create(new Position(0, 0, Orientation.South));

            Assert.IsType<SouthRouter>(router);
        }
    }
}

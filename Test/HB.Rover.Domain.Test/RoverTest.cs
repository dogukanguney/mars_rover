using HB.Rover.Domain.Enums;
using HB.Rover.Domain.Interfaces;
using HB.Rover.Domain.RouterManagement;
using HB.Rover.Domain.RouterManagement.Routers;
using NSubstitute;
using Xunit;

namespace HB.Rover.Domain.Test
{
    public class RoverTest
    {
        private IPlateau _plateau;
        private IRouterFactory _routerFactory;

        public RoverTest()
        {
            _plateau = Substitute.For<IPlateau>();
            _plateau.Height = 5;
            _plateau.Width = 5;

            _routerFactory = Substitute.For<IRouterFactory>();
            _routerFactory.Create(null).ReturnsForAnyArgs(new NorthRouter());
        }

        [Fact]
        public void CoridinateY_Should_One_When_Move_To_North()
        {
            Rover rover = new Rover(_plateau, _routerFactory, new Position(0, 0, Orientation.North));
            rover.Move();

            Assert.Equal(1, rover.GetCurrentPosition().CoordinateY);
        }

        [Fact]
        public void Orientation_Should_West_When_Direction_To_Left()
        {
            Rover rover = new Rover(_plateau, _routerFactory, new Position(0, 0, Orientation.North));
            rover.SetDirection(Direction.Left);

            Assert.Equal(Orientation.West, rover.GetCurrentPosition().Orienation);
        }

        [Fact]
        public void Orientation_Should_West_When_Parameter_Is_Left()
        {
            Rover rover = new Rover(_plateau, _routerFactory, new Position(0, 0, Orientation.North), "L");

            Assert.Equal(Orientation.West, rover.GetCurrentPosition().Orienation);
        }
    }
}
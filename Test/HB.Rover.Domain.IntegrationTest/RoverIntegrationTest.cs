using HB.Rover.Domain.Enums;
using HB.Rover.Domain.Interfaces;
using HB.Rover.Domain.RouterManagement;
using Xunit;

namespace HB.Rover.Domain.IntegrationTest
{
    public class RoverIntegrationTest
    {
        private IRouterFactory _routerFactory;
        private IPlateau _plateau;

        public RoverIntegrationTest()
        {
            _routerFactory = new RouterFactory();
            _plateau = new Plateau(5, 5);
        }

        [Fact]
        public void Check_First_Rover_Position()
        {
            Rover rover = new Rover(_plateau, _routerFactory, new Position(1, 2, Orientation.North), "LMLMLMLMM");

            Assert.Equal("1 3 N", rover.GetCurrentPosition().ToString());
        }

        [Fact]
        public void Check_Second_Rover_Position()
        {
            Rover rover = new Rover(_plateau, _routerFactory, new Position(3, 3, Orientation.East), "MMRMMRMRRM");

            Assert.Equal("5 1 E", rover.GetCurrentPosition().ToString());
        }
    }
}
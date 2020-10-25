using HB.Rover.Domain.Enums;
using HB.Rover.Domain.Exceptions;
using HB.Rover.Domain.Interfaces;
using NSubstitute;
using Xunit;

namespace HB.Rover.Domain.Test
{
    public class PlateauTest
    {
        [Fact]
        public void Does_Not_Throw_Validate_To_Position_When_Position_Is_Correct()
        {
            IRover rover = Substitute.For<IRover>();
            rover.GetCurrentPosition().Returns(new Position(0, 0, Orientation.North));
            Plateau plateau = new Plateau(1, 1);

            plateau.ValidateToPosition(rover);
        }

        [Fact]
        public void Throw_Exception_Validate_To_Position_When_Position_Is_Wrong()
        {
            IRover rover = Substitute.For<IRover>();
            rover.GetCurrentPosition().Returns(new Position(3, 3, Orientation.North));
            Plateau plateau = new Plateau(1, 1);

            Assert.Throws<OutOfPlateauException>(() => plateau.ValidateToPosition(rover));
        }
    }
}

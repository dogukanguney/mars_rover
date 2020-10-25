using HB.Rover.Domain.Exceptions;
using HB.Rover.Domain.Interfaces;

namespace HB.Rover.Domain
{
    public sealed class Plateau : IPlateau
    {
        public Plateau(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public void ValidateToPosition(IRover rover)
        {
            Position position = rover.GetCurrentPosition();

            if (position.CoordinateX > Width)
            {
                throw new OutOfPlateauException(string.Format("Your X coordinate is {0} but the plateau max X coordinate is {1}", position.CoordinateX, Width));
            }

            if (position.CoordinateY > Height)
            {
                throw new OutOfPlateauException(string.Format("Your Y coordinate is {0} but the plateau max Y coordinate is {1}", position.CoordinateY, Height));
            }
        }
    }
}
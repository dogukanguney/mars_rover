using HB.Rover.Domain.Enums;

namespace HB.Rover.Domain.RouterManagement.Routers
{
    public class EastRouter : IRouter
    {
        public void SetToOrientation(Position position, Direction direction)
        {
            position.Orienation = direction == Direction.Left ? Orientation.North : Orientation.South;
        }

        public void Move(Position position)
        {
            position.CoordinateX++;
        }
    }
}

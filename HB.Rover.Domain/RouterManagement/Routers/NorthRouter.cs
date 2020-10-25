using HB.Rover.Domain.Enums;

namespace HB.Rover.Domain.RouterManagement.Routers
{
    public class NorthRouter : IRouter
    {
        public void SetToOrientation(Position position, Direction direction)
        {
            position.Orienation = direction == Direction.Left ? Orientation.West : Orientation.East;
        }

        public void Move(Position position)
        {
            position.CoordinateY++;
        }
    }
}

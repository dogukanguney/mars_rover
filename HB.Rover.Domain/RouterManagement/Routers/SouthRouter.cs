using HB.Rover.Domain.Enums;

namespace HB.Rover.Domain.RouterManagement.Routers
{
    public class SouthRouter : IRouter
    {
        public void SetToOrientation(Position position, Direction direction)
        {
            position.Orienation = direction == Direction.Left ? Orientation.East : Orientation.West;
        }

        public void Move(Position position)
        {
            position.CoordinateY--;
        }
    }
}

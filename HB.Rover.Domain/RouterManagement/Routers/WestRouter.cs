using HB.Rover.Domain.Enums;

namespace HB.Rover.Domain.RouterManagement.Routers
{
    public class WestRouter : IRouter
    {
        public void SetToOrientation(Position position, Direction direction)
        {
            position.Orienation = direction == Direction.Left ? Orientation.South : Orientation.North;
        }

        public void Move(Position position)
        {
            position.CoordinateX--;
        }
    }
}

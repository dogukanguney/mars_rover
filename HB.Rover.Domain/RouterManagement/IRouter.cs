using HB.Rover.Domain.Enums;

namespace HB.Rover.Domain.RouterManagement
{
    public interface IRouter
    {
        void SetToOrientation(Position position, Direction direction);

        void Move(Position position);
    }
}

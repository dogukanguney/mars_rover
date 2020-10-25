using HB.Rover.Domain.Enums;

namespace HB.Rover.Domain.Interfaces
{
    public interface IRover
    {
        IPlateau Plateau { get; set; }

        void Move();

        void SetDirection(Direction direction);

        Position GetCurrentPosition();
    }
}

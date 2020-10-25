namespace HB.Rover.Domain.Interfaces
{
    public interface IPlateau
    {
        int Width { get; set; }

        int Height { get; set; }

        void ValidateToPosition(IRover rover);
    }
}

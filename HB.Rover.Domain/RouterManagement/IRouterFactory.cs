namespace HB.Rover.Domain.RouterManagement
{
    public interface IRouterFactory
    {
        IRouter Create(Position currentPosition);
    }
}

using HB.Rover.Domain.Enums;
using HB.Rover.Domain.RouterManagement.Routers;
using System;

namespace HB.Rover.Domain.RouterManagement
{
    public sealed class RouterFactory : IRouterFactory
    {
        public IRouter Create(Position currentPosition)
        {
            switch (currentPosition.Orienation)
            {
                case Orientation.East:
                    {
                        return new EastRouter();
                    }
                case Orientation.North:
                    {
                        return new NorthRouter();
                    }
                case Orientation.South:
                    {
                        return new SouthRouter();
                    }
                case Orientation.West:
                    {
                        return new WestRouter();
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(currentPosition));
                    }
            }
        }
    }
}

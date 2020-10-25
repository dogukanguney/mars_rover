using System;
using HB.Rover.Domain.Enums;
using HB.Rover.Infrastructure.Utilities;
using HB.Rover.Domain.RouterManagement;
using HB.Rover.Infrastructure.SeedWork;
using HB.Rover.Domain.Interfaces;

namespace HB.Rover.Domain
{
    public class Rover : Entity, IAggregateRoot, IRover
    {
        private readonly Position _position;
        private readonly IRouterFactory _routerFactory;
        private IPlateau _plateau;

        public Rover()
        {
            _position = new Position(0, 0, Orientation.North);
            _routerFactory = new RouterFactory();
            _plateau = new Plateau(5, 5);
        }

        public Rover(IPlateau plateau, IRouterFactory routerFactory, Position position)
        {
            Guard.AgainstNullArgument("plateau", plateau);
            Guard.AgainstNullArgument("routerFactory", routerFactory);
            Guard.AgainstNullArgument("position", position);

            _position = position;
            _routerFactory = routerFactory;
            _plateau = plateau;
        }

        public Rover(IPlateau plateau, IRouterFactory routerFactory, Position position, string parameters)
            : this(plateau, routerFactory, position)
        {

            foreach (char param in parameters)
            {
                switch (param)
                {
                    case 'L':
                        {
                            SetDirection(Direction.Left);
                            break;
                        }
                    case 'R':
                        {
                            SetDirection(Direction.Right);
                            break;
                        }
                    case 'M':
                        {
                            Move();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Unexpected parameter", param.ToString());
                        }
                }
            }
        }

        public Position GetCurrentPosition()
        {
            return _position;
        }

        public IPlateau Plateau
        {
            get { return _plateau; }
            set { _plateau = value; }
        }

        public void Move()
        {
            IRouter router = _routerFactory.Create(_position);
            router.Move(_position);
            _plateau.ValidateToPosition(this);
        }

        public void SetDirection(Direction direction)
        {
            IRouter router = _routerFactory.Create(_position);
            router.SetToOrientation(_position, direction);
            _plateau.ValidateToPosition(this);
        }
    }
}

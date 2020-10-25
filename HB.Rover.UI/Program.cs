using HB.Rover.Domain;
using HB.Rover.Domain.Enums;
using HB.Rover.Domain.RouterManagement;
using System;

namespace HB.Rover.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IRouterFactory routerFactory = new RouterFactory();
            Plateau plateau = new Plateau(5, 5);

            var rover = new Domain.Rover(plateau, routerFactory, new Position(1, 2, Orientation.North), "LMLMLMLMM");

            Console.WriteLine(rover.GetCurrentPosition().ToString());
            Console.ReadLine();

            var rover2 = new Domain.Rover(plateau, routerFactory, new Position(3, 3, Orientation.East), "MMRMMRMRRM");
            Console.WriteLine(rover2.GetCurrentPosition().ToString());
            Console.ReadLine();
        }
    }
}

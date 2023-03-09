using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Galactica.SpaceObject;
using System.Threading.Tasks;

namespace Galactica
{
    sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }


        public Moon()
        {
            
        }

        public Moon(string name, int id, StarType type, double diameter, int rotation, int revolution, double x, double y, Planet orbit)
        {
            Pos = new Position();
            Name = name;
            Id = id;
            Type = type;
            Diameter = diameter;
            RotationPeriod = rotation;
            RevolutionPeriod = revolution;
            Pos.X = x;
            Pos.Y = y;
            Orbiting = orbit;
        }

        public double Distance(Position planet)
        {
            /* Debug
            Console.WriteLine($"Orbit X: {planet.X} | Y: {planet.Y}");
            Console.WriteLine($"{Name} X: {this.Pos.X} |  Y: {this.Pos.Y}");
            */
            double dX = this.Pos.X - Orbiting.Pos.X;
            double dY = this.Pos.Y - Orbiting.Pos.Y;
            double distance = Math.Sqrt(Math.Pow(dX,2) + Math.Pow(dY,2));
            return distance;
        }
    }
}

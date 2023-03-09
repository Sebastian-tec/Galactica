using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class Planet : Star
    {
        public PlanetType PlanetType { get; set; }
        public double Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }

        public List<Moon> Moon { get; set; } = new List<Moon>();

        public virtual double Distance(Position star)
        {
            double dX = this.Pos.X - star.X;
            double dY = this.Pos.Y - star.Y;
            double distance = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));
            return distance;
        }

        public Planet()
        {
            AddMoons();
        }
        public Planet(string name, int id, PlanetType type, double diameter, int rotation, int revolution, double x, double y)
        {
            Pos = new Position();
            Name = name;
            Id = id;
            PlanetType = type;
            Diameter = diameter;
            RotationPeriod = rotation;
            RevolutionPeriod = revolution;
            Pos.X = x;
            Pos.Y = y;
            AddMoons();
        }

        public void AddMoons()
        {
            StockData data = new StockData();

            Moon.AddRange(data.GetMoons());
        }
    }
}

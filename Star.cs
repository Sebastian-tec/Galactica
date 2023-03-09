using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Galactica.SpaceObject;

namespace Galactica
{
    internal class Star : SpaceObject
    {
        
        public StarType Type { get; set; }
        public double Temperature { get; set; } 
        public List<Planet> Planets { get; set; }

        public enum PlanetType
        {
            Terrestial,
            Giant,
            Dwarf,
            Gas_Giant,
        }

        public Star()
        {
            Planets = new List<Planet>();
            AddPlanets();
        }
        public Star(string name, int id, StarType type, double temperature, double x, double y)
        {
            Planets = new List<Planet>();
            Pos = new Position();
            Name = name;
            Id = id;
            Type = type;
            Temperature = temperature;
            Pos.X = x;
            Pos.Y = y;
            AddPlanets();
        }

        public void AddPlanets()
        {
            StockData data = new StockData();
            Planets.AddRange(data.GetPlanets());
        }

        public void PrintDistance()
        {
            foreach (Planet planet in Planets)
            {
                Console.WriteLine($"{planet.Distance(planet.Pos)}");
            }
        }


    }
}

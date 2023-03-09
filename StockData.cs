using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class StockData
    {
        public List<Planet> PlanetList { get; set; }

        public List<Moon> MoonList { get; set; }
        public Star Star { get; set; }

        public StockData()
        {
            PlanetList = new List<Planet>();
            MoonList = new List<Moon>();
        }
        public void CreatePlanets()
        {
            PlanetList.Add(new Planet("Mercury", 0, Star.PlanetType.Terrestial, 4879400, 1408, 88, 8, 8));
            PlanetList.Add(new Planet("Venus", 1, Star.PlanetType.Terrestial, 12103600, 5832, 225, 4, 4));
            PlanetList.Add(new Planet("Earth", 2, Star.PlanetType.Terrestial, 12742000, 24, 365, 1, 1));
            PlanetList.Add(new Planet("Mars", 3, Star.PlanetType.Terrestial, 6794000, 25, 687, 11, 11));
            PlanetList.Add(new Planet("Jupiter", 4, Star.PlanetType.Gas_Giant, 142984000, 10, 4380, 9, 9));
            PlanetList.Add(new Planet("Saturn", 5, Star.PlanetType.Gas_Giant, 120536000, 11, 10585, 5, 5));
            PlanetList.Add(new Planet("Uranus", 6, Star.PlanetType.Gas_Giant, 51118000, 17, 30660, 3, 3));
            PlanetList.Add(new Planet("Neptune", 7, Star.PlanetType.Giant, 49528000, 16, 60225, 7, 7));
        }

        public List<Planet> GetPlanets()
        {
            return PlanetList;
        }

        public void CreateMoons()
        {

            MoonList.Add(new Moon("Luna", 0, SpaceObject.StarType.BlueNeutron, 3474800, 27, 660, 18, 18, PlanetList.Find(x => x.Name == "Earth")));
            MoonList.Add(new Moon("Phobos", 1, SpaceObject.StarType.BlueNeutron, 11200, 8, 8, 19, 19, PlanetList.Find(x => x.Name == "Mars")));
            MoonList.Add(new Moon("Deimos", 2, SpaceObject.StarType.BlueNeutron, 12400, 8, 8, 20, 20, PlanetList.Find(x => x.Name == "Mars")));
            MoonList.Add(new Moon("Io", 3, SpaceObject.StarType.BlueNeutron, 1821000, 42, 42, 21, 21, PlanetList.Find(x => x.Name == "Jupiter")));
            MoonList.Add(new Moon("Europa", 4, SpaceObject.StarType.BlueNeutron, 1561000, 42, 42, 22, 22, PlanetList.Find(x => x.Name == "Jupiter")));
            MoonList.Add(new Moon("Ganymede", 5, SpaceObject.StarType.BlueNeutron, 2631000, 42, 42, 23, 23, PlanetList.Find(x => x.Name == "Jupiter")));
            MoonList.Add(new Moon("Titan", 6, SpaceObject.StarType.BlueNeutron, 2575000, 42, 42, 24, 24, PlanetList.Find(x => x.Name == "Saturn")));

        }
        public List<Moon> GetMoons()
        {
            return MoonList;
        }

        public void CreateStars()
        {
            Star = new Star("Sun", 0, SpaceObject.StarType.YellowDwarf, 5778, 0, 0);
        }
        public Star GetStar()
        {
            return Star;
        }

        public void PrintMoons()
        {
            CreateMoons();
            foreach (Moon moon in MoonList)
            {
                Console.WriteLine($"[{moon.Id}] {moon.Name} | Size: {moon.Diameter} | Type: {moon.Type} | Rotation period: {moon.RotationPeriod}  | Revolution period: {moon.RevolutionPeriod}\nOrbiting: {moon.Orbiting.Name} | Distance: {moon.Distance(moon.Orbiting.Pos):N2}\n");
            }
            Console.WriteLine("\n\n");

        }

        public void PrintPlanets()
        {
            CreatePlanets();
            foreach (var item in PlanetList)
            {
                Console.WriteLine($"[{item.Id}] {item.Name} | Type: {item.Type} | Size: {item.Diameter} | Distance: {item.Distance(Star.Pos):N2}");
            }
            Console.WriteLine("\n\n");
        }

        public void PrintStar()
        {
            CreateStars();
            Console.WriteLine($"[{Star.Id}] {Star.Name} | Type: {Star.Type} | Temperature: {Star.Temperature}\n");
        }
    }
}

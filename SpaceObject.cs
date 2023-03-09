using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{

    internal abstract class SpaceObject
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Position Pos { get; set; }
        public enum StarType
        {
            YellowDwarf,
            White,
            BlueNeutron,
            RedGiant,
        }

        public class Position
        {

            public double X { get; set; }
            public double Y { get; set; }

            public override string ToString()
            {
                return (X, Y).ToString();
            }
        }

    }
}

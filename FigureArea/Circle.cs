using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle()
        {
            Radius = 0;
        }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.Round(2 * Math.PI * Radius, 3);
        }
    }
}

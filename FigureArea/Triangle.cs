using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle : Shape
    {
        public Point First { get; set; }
        public Point Second { get; set; }
        public Point Third { get; set; }

        public Triangle()
        {
            this.First = new Point();
            this.Second = new Point();
            this.Third = new Point();
        }
        public Triangle(Point first, Point second, Point third)
        {
            this.First = first;
            this.Second = second;
            this.Third = third;
        }
        public override double GetArea()
        {
            return Math.Round(Math.Abs(0.5 * ((First.X - Third.X) * (Second.Y - Third.Y) - (Second.X - Third.X) * (First.Y - Third.Y))), 3);
        }

        public bool IsASquareTriangle()
        {
            double firstSide = Math.Sqrt((Second.X - First.X) * (Second.X - First.X) + (Second.Y - First.Y) * (Second.Y - First.Y));
            double secondSide = Math.Sqrt((Third.X - First.X) * (Third.X - First.X) + (Third.Y - First.Y) * (Third.Y - First.Y));
            double thirdSide = Math.Sqrt((Third.X - Second.X) * (Third.X - Second.X) + (Third.Y - Second.Y) * (Third.Y - Second.Y));
            double firstDiag = firstSide * firstSide;
            double secondDiag = secondSide * secondSide;
            double thirdDiag = thirdSide * thirdSide;
            if ((firstDiag == secondDiag + thirdDiag) || (secondDiag == firstDiag + thirdDiag) || (thirdDiag == firstDiag + secondDiag)) 
                return true; 
            else 
                return false;
        }
    }
}

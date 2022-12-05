using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public abstract class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }
}

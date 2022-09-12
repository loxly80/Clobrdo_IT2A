using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo_IT2A
{
    public class Figure
    {
        public FigureColor Color { get; }

        public Figure(FigureColor color)
        {
            Color = color;
        }
    }

    public enum FigureColor
    {
        Color1,
        Color2,
        Color3,
        Color4
    }
}

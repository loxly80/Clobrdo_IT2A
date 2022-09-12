using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo_IT2A
{
    public class Board
    {
        private Figure[] path;
        private Figure[] color1Home;
        private Figure[] color2Home;
        private Figure[] color3Home;
        private Figure[] color4Home;

        public int Color1Start { get; }
        public int Color2Start { get; }
        public int Color3Start { get; }
        public int Color4Start { get; }

        public Board()
        {
            path = new Figure[40];
            color1Home = new Figure[4];
            color2Home = new Figure[4];
            color3Home = new Figure[4];
            color4Home = new Figure[4];
            Color1Start = 0;
            Color2Start = 10;
            Color3Start = 20;
            Color4Start = 30;
        }
    }
}

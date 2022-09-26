using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobrdo_IT2A
{
    public class Game
    {
        public Board Board { get; }
        public Player[] Players { get; }
        public Dice Dice { get; }

        public Game(int playersCount)
        {
            if (playersCount <= 0)
            {
                throw new ArgumentException("Počet hráčů musí být alespoň 1");
            }
            if (playersCount > 4)
            {
                throw new ArgumentException("Počet hráčů musí být maximálně 4");
            }
            Players = new Player[playersCount];
            for(int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player((FigureColor)i);
            }
            Dice = new Dice();
            Board = new Board();
        }
    }
}

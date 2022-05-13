using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLife
{
    internal class Coordinate
    {
        int X;
        int Y;

        private Coordinate ShiftUp() => new(X, Y - 1);
        private Coordinate ShiftDown() => new(X, Y + 1);
        public Coordinate ShiftLeft() => new(X - 1, Y); 
        public Coordinate ShiftRight() => new(X + 1, Y);
        internal protected Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
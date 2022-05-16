namespace SquareLife
{
    internal class Coordinate
    {
        public int X;
        public int Y;

        public Coordinate ShiftUp() => new(X, Y - 1);
        public Coordinate ShiftDown() => new(X, Y + 1);
        public Coordinate ShiftLeft() => new(X - 1, Y); 
        public Coordinate ShiftRight() => new(X + 1, Y);
        internal protected Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
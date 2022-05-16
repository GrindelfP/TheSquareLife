namespace SquareLife
{
    internal class Position
    {
        internal protected Position(Coordinate coordinates)
        {
        }
    }
    struct EntityPosition
    {
        Position Position;
        Color Color;
        public EntityPosition(Position position, Color color)
        {
            Position = position;
            Color = color;
        }
    }
}
using System.Collections.Generic;

namespace SquareLife
{
    internal class Position
    {
        public HashSet<Coordinate> Coordinates;
        internal protected Position(HashSet<Coordinate> coordinates)
        {
            Coordinates = coordinates;
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
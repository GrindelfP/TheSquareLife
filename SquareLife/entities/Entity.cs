using System;
using System.Collections.Generic;

namespace SquareLife
{
    internal abstract class Entity
    {
        protected string EntColor { get; set; }
        protected EntitySize EntSize { get; set; }
        protected string Id { get; set; }
        protected abstract Position Position();
        public Position Move(List<Position> positions)
        {
            var random = new Random();
            var position = positions[random.Next(0, positions.Count)];
            return position;
        }
        public Entity(string id, Position originalPosition)
        {
            Id = id;
            EntColor = ""; //!
            EntSize = EntitySize.MIN_ENTITY_AREA_SIZE; //!
        }
    }
}
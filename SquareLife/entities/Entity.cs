using System;
using System.Collections.Generic;

namespace SquareLife
{
    internal abstract class Entity
    {
        protected Position Position { get; }
        protected bool IsAlive = true;
        protected Guid Id { get; }
        protected abstract Color Color { get; set; }
        protected abstract EntitySize Size { get; set; }
        public void Validate()
        {
            throw new NotImplementedException(); 
            // Ask how does it work and how to imple,ent in using C#. What is 'Class<in Entity>'
        }
        public Position Move(List<Position> positions)
        {
            var random = new Random();
            var position = positions[random.Next(0, positions.Count)];
            return position;
        }

        public Entity(Position position)
        {
            Position = position;
            Id = Guid.NewGuid();
        }
    }
}
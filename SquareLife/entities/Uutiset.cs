using System;

namespace SquareLife
{
    internal class Uutiset : Entity
    {
        protected override Color Color { get; set; }
        protected override EntitySize Size { get; set; }
        public Uutiset(Position position) : base(position)
        {
            Color = Color.RED;
            Size = EntitySize.KUVAHAKU_SIZE;
            Validate();
        }
    }
}
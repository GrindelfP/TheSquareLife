using System;

namespace SquareLife
{
    internal class Kuvat : Entity
    {
        protected override Color Color { get; set; }
        protected override EntitySize Size { get; set; }
        public Kuvat(Position position) : base(position)
        {
            Color = Color.GREEN;
            Size = EntitySize.KUVAHAKU_SIZE;
            Validate();
        }
    }
}
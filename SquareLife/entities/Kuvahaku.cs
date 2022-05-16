using System;

namespace SquareLife
{
    internal class Kuvahaku : Entity
    {
        protected override Color Color { get; set; }
        protected override EntitySize Size { get; set; }
        public Kuvahaku(Position position) : base(position)
        {
            Color = Color.BLUE;
            Size = EntitySize.KUVAHAKU_SIZE;
            Validate();
        }
    }
}
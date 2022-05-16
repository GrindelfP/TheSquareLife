using System;

namespace SquareLife
{
    internal class Kuvahaku : Entity
    {
        public override Color Color { get; }
        public override int Size { get; set; }
        public Kuvahaku(Position position) : base(position)
        {
            Color = Color.BLUE;
            Size = EntitySize.KUVAHAKU_SIZE;
            Validate();
        }
    }
}
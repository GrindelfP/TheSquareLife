using System;

namespace SquareLife
{
    internal class Kuvat : Entity
    {
        public override Color Color { get; }
        public override int Size { get; set; }
        public Kuvat(Position position) : base(position)
        {
            Color = Color.GREEN;
            Size = EntitySize.KUVAHAKU_SIZE;
            Validate();
        }
    }
}
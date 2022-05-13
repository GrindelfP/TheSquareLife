using System;

namespace SquareLife
{
    internal class Kuvahaku : Entity
    {
        protected Position position;
        protected string Color; //!
        protected EntitySize Size;

        protected override Position Position()
        {
            return position;
        }
        protected override Position Move()
        {
            throw new NotImplementedException();
        }
        public Kuvahaku(string id, Position originalPosition) : base(id, originalPosition)
        {
            position = originalPosition;
            Color = ""; //!
            Size = EntitySize.KUVAHAKU_SIZE;
        }
    }
}
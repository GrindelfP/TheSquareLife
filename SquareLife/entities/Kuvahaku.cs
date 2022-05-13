using System;
using SquareLife.entities;

namespace SquareLife
{
    internal class Kuvahaku : Entity
    {
        protected Position position;
        protected string Color; //!
        protected int Size; //!

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
            Size = 1; //!
        }
    }
}

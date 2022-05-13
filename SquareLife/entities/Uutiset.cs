using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLife
{
    internal class Uutiset : Entity 
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
        public Uutiset(string id, Position originalPosition) : base(id, originalPosition)
        {
            position = originalPosition;
            Color = ""; //!
            Size = 1; //!
        }
    }
}

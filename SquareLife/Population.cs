using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLife
{
    internal class Population
    {
        Uutiset Uutiset;
        Kuvahaku Kuvahakus;
        Kuvat Kuvatus;

        // INIT
        // FUN ENTITIES
        // FUN ENTITYPOSITIONS
        // COMPANION OBJECT (???)

        public Population(Uutiset uutiset, Kuvahaku kuvahakus, Kuvat kuvatus)
        {
            Uutiset = uutiset;
            Kuvahakus = kuvahakus;
            Kuvatus = kuvatus;
        }
    }
}

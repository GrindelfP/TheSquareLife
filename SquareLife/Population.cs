using System;
using System.Collections.Generic;

namespace SquareLife
{
    internal class Population
    {
        Uutiset Uutiset;
        Kuvahaku Kuvahakus;
        Kuvat Kuvatus;

        // INIT
        // COMPANION OBJECT (???)

        public List<Entity> Entities()
        {
            throw new NotImplementedException();
        }

        public List<EntityPosition> EntityPositions()
        {
            throw new NotImplementedException();
        }

        public Population? GeneratePopulation(int numOfKuvahakus, int numOfuvatus, BoardSize sizeOfBoard)
        {
            throw new NotImplementedException();
        }

        public Population(Uutiset uutiset, Kuvahaku kuvahakus, Kuvat kuvatus)
        {
            Uutiset = uutiset;
            Kuvahakus = kuvahakus;
            Kuvatus = kuvatus;
        }
    }
}
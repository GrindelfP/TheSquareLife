using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLife
{
    internal abstract class BoardVisualizer : IVisualizer
    {
        public abstract void Visualize();
    }
}

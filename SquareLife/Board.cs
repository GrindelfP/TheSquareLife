using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLife
{
    internal class Board
    {
        public BoardSize BoardSize { get; set; }

        public void Update(List<EntityPosition> entityPositions)
        {
            throw new NotImplementedException();
        }
        public Board(BoardSize boardSize)
        {
            BoardSize = boardSize;
        }
    }
    class BoardSize
    {
        public static int NumberOfRows;
        public static int NumberOfColumns;

        public BoardSize(int numberOfRows, int numberOfColumns)
        {
            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }
    }
}

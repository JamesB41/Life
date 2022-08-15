using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NeighborFactory
{
    public INeighborCreator[] CreateNeighbors= { new TopLeftNeighbor(), new TopNeighbor(), new TopRightNeighbor(), new LeftNeighbor(), new RightNeighbor(), new BottomLeftNeighbor(), new BottomNeighbor(), new BottomRightNeighbor() };
    public void GenerateNeighbors(Cell cell, Grid grid)
    {
        foreach(INeighborCreator neighbor in CreateNeighbors)
        {
            neighbor.GetNeighbor(cell, grid);
        }
    }
}

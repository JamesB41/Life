using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstGeneration : Generation
{
    public Grid Generation(Grid FirstGen)
    {
        NeighborFactory neighborFactory = new NeighborFactory();

        foreach (Row row in FirstGen.Rows)
        {
            foreach (Cell cell in row.Cells)
            {
                neighborFactory.GenerateNeighbors(cell, FirstGen);
            }
        }

        return FirstGen;
    }
}

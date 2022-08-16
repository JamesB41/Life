using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NextGeneration : Generation
{
    public Grid Generation(Grid LastGen)
    {
        Grid NextGen = new Grid(LastGen.Height, LastGen.Width);
        NeighborFactory neighborFactory = new NeighborFactory();

        for(int i = 0; i < LastGen.Height; i++)
        {
            Row LastGenRow = LastGen.Rows[i];
            Row NextGenRow = new Row();
            NextGen.Rows.Add(NextGenRow);
            for(int j = 0; j < LastGen.Width; j++)
            {
                Cell LastGenCell = LastGenRow.Cells[j];
                Cell NextGenCell = new Cell(false, LastGenCell._WidthIndex, LastGenCell._HeightIndex);
                int aliveNeighbors = AliveNeighbors(LastGenCell);

                if (LastGenCell._IsAlive)
                {
                    if (aliveNeighbors < 2)
                    {
                        NextGenCell._IsAlive = false;
                    }
                    else if (aliveNeighbors > 3)
                    {
                        NextGenCell._IsAlive = false;
                    }
                    else
                    {
                        NextGenCell._IsAlive = true;
                    }
                }
                else
                {
                    if(aliveNeighbors == 3)
                    {
                        NextGenCell._IsAlive = true;
                    }
                }
                NextGenRow.Cells.Add(NextGenCell);
            }
        }
        
        return NextGen;
    }

    private int AliveNeighbors(Cell cell)
    {
        int AliveNeighbors = 0;
        foreach (Cell neighbor in cell._Neighbors)
        {
            if (neighbor._IsAlive)
            {
                AliveNeighbors++;
            }
        }
        return AliveNeighbors;
    }
}

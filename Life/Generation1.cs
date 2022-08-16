using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Generation1
{
    Grid FirstGen { get; set; }
    Grid NextGen { get; set; }
    public void FirstGeneration()
    {
        GridFactory gridFactory = new GridFactory();
        FirstGen = gridFactory.Generate(10, 10);
        NeighborFactory neighborFactory = new NeighborFactory();

        foreach (Row row in FirstGen.Rows)
        {
            foreach (Cell cell in row.Cells)
            {
                neighborFactory.GenerateNeighbors(cell, FirstGen);
            }
        }
    }

    public void NextGeneration()
    {
        NextGen = FirstGen;
        foreach(Row row in NextGen.Rows)
        {
            foreach(Cell cell in row.Cells)
            {
                int aliveNeighbors = AliveNeighbors(cell);
                if (cell._IsAlive)
                {
                    if (aliveNeighbors < 2)
                    {
                        cell._IsAlive = false;
                    }

                    if (aliveNeighbors > 3)
                    {
                        cell._IsAlive = false;
                    }
                }
                else
                {
                    if (aliveNeighbors == 3)
                    {
                        cell._IsAlive = true;
                    }
                }
            }
        }
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

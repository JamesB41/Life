using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Simulation
{
    public void StartSimulation(Grid grid)
    {
        DrawSimulation(grid);
        NextGeneration(grid);
    }

    private void NextGeneration(Grid grid)
    {
        foreach (Row row in grid.Rows)
        {
            foreach (Cell cell in row.Cells)
            {
                NeighborFactory factory = new NeighborFactory();
                factory.GenerateNeighbors(cell, grid);
                int aliveNeighbors = AliveNeighbors(cell);

                if (cell._IsAlive)
                {
                    if(aliveNeighbors < 2)
                    {
                        cell._IsAlive = false;
                    }

                    if(aliveNeighbors > 3)
                    {
                        cell._IsAlive = false;
                    }
                }
                else
                {
                    if(aliveNeighbors == 3)
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
        foreach(Cell neighbor in cell._Neighbors)
        {
            if (neighbor._IsAlive)
            {
                AliveNeighbors++;
            }
        }
        return AliveNeighbors;
    }

    private void DrawSimulation(Grid grid)
    {
        string Life = "";
        foreach(Row row in grid.Rows)
        {
            foreach(Cell cell in row.Cells)
            {
                if (cell._IsAlive)
                {
                    Life += " \u2580 ";
                }
                else
                {
                    Life += "   ";
                }
            }
            Life += "\n";
        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine();
/*        Console.SetCursorPosition(0, Console.WindowTop);
*/        Console.Write(Life.TrimEnd('\n'));
    }
}

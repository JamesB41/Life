using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Simulation
{
    public void StartSimulation(int MaxGenerations)
    {
        GridFactory gridFactory = new GridFactory();
        Grid FirstGenGrid = gridFactory.Generate(10, 20);

        FirstGeneration FirstGen = new FirstGeneration();
        FirstGenGrid = FirstGen.Generation(FirstGenGrid);

        foreach (Row row in FirstGenGrid.Rows)
        {
            foreach (Cell cell in row.Cells)
            {
                cell._IsAlive = false;
            }
        }

        FirstGenGrid.Rows[1].Cells[3]._IsAlive = true;
        FirstGenGrid.Rows[2].Cells[1]._IsAlive = true;
        FirstGenGrid.Rows[2].Cells[3]._IsAlive = true;
        FirstGenGrid.Rows[3].Cells[2]._IsAlive = true;
        FirstGenGrid.Rows[3].Cells[3]._IsAlive = true;


        DrawSimulation(FirstGenGrid, 0);

        NextGeneration NextGen = new NextGeneration();
        Grid NextGenGrid = NextGen.Generation(FirstGenGrid);

        NeighborFactory n = new NeighborFactory();
        int count = 0;
        while(count++ < MaxGenerations)
        {

            foreach (Row row in NextGenGrid.Rows)
            {
                foreach (Cell cell in row.Cells)
                {
                    n.GenerateNeighbors(cell, NextGenGrid);
                }
            }

            DrawSimulation(NextGenGrid, count);
            NextGenGrid = NextGen.Generation(NextGenGrid);
            
        }

    }


    private void DrawSimulation(Grid grid, int iterationNum)
    {
        Console.WriteLine(iterationNum);
        string Life = "";
        foreach(Row row in grid.Rows)
        {
            foreach(Cell cell in row.Cells)
            {
                if (cell._IsAlive)
                {
                    Life += "\u25A0 ";
                }
                else
                {
                    Life += "  ";
                }
            }
            Life += "\n";
        }
        /*        Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();*/

        Console.SetCursorPosition(0, Console.WindowTop);
        System.Threading.Thread.Sleep(100);

        Console.Write(Life.TrimEnd('\n'));
    }
}

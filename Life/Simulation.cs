using Life.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Simulation
{
    public static void StartSimulation()
    {
        Pattern p = new Pulsar();

        Grid grid = new(30, 30);

        int pattern_left = 5;
        int pattern_top = 5;

        foreach (var position in p.pattern)
        {
            grid.Rows[pattern_top + position.Item1].Cells[pattern_left + position.Item2].IsAlive = true;
        }

        while(true)
        {
            Simulation.DrawSimulation(grid);
            grid.Iterate();
        }
    }

    private static void DrawSimulation(Grid grid)
    {
        string Life = "";
        foreach(Row row in grid.Rows)
        {
            foreach(Cell cell in row.Cells)
            {
                Life += cell.IsAlive ? "\u25A0 " : "  ";
            }
            Life += "\n";
        }

        Console.SetCursorPosition(0, Console.WindowTop);
        System.Threading.Thread.Sleep(750);

        Console.Write(Life.TrimEnd('\n'));
    }
}

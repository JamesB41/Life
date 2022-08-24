using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Draw
{
    public void DrawSimulation(Grid grid)
    {
        string Life = "";
        foreach (Row row in grid.Rows)
        {
            foreach (Cell cell in row.Cells)
            {
                if (cell.IsAlive)
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
        */
        Console.Write(Life.TrimEnd('\n'));
    }
}

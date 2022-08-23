using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GridFactory
{
    public Grid Generate(int Width, int Height)
    {
        Random RandNum = new Random();
        Grid grid = new Grid(Width, Height);

        for (int i = 0; i < Height; i++)
        {
            Row row = new Row();
            grid.Rows.Add(row);
            for (int j = 0; j < Width; j++)
            {
                int num = RandNum.Next(2);
                Cell cell = new Cell(true, j, i);
                cell._IsAlive = (num == 0) ? true : false;
                row.Cells.Add(cell);
            }
        }
        return grid;
    }
}

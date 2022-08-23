using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Grid
{
    public List<Row> Rows = new();

    public Grid(int height, int width)
    {
        for (int i = 0; i < height; i++)
        {
            Row row = new(width);

            for (int j = 0; j < width; j++)
            {
                row.Cells.Add(new Cell());
            }

            this.Rows.Add(row);
        }
    }

    public int getHeight()
    {
        return this.Rows.Count;
    }
    public int getWidth()
    {
        return this.Rows[0].Cells.Count;
    }
}
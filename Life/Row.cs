using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Row
{
    public List<Cell> Cells = new List<Cell>();
    public Grid Grid { get; set; }
    public int RowNumber { get; set; }
    
    public Row(int width, Grid grid, int row_number)
    {
        this.Grid = grid;
        this.RowNumber = row_number;

        for (int i = 0; i < width; i++)
        {
            this.Cells.Add(new Cell(this));
        }
    }
}

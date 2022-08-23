using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Row
{
    public List<Cell> Cells = new List<Cell>();
    
    public Row(int width)
    {
        for (int i = 0; i < width; i++)
        {
            this.Cells.Add(new Cell());
        }
    }
}

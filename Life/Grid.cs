using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Grid
{
    public List<Row> Rows = new List<Row>();
    public int Height;
    public int Width;

    public Grid(int height, int width)
    {
        Height = height;
        Width = width;
    }
}

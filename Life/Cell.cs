using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cell
{
    public bool _IsAlive { get; set; }
    public int _WidthIndex { get; set; }
    public int _HeightIndex { get; set; }
    public List<Cell> _Neighbors = new List<Cell> ();

    public Cell(bool IsAlive, int WidthIndex, int HeightIndex)
    {
        _IsAlive = IsAlive;
        _WidthIndex = WidthIndex;
        _HeightIndex = HeightIndex;
    }
}

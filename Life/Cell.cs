using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cell
{
    public bool IsAlive { get; set; }
    public int WidthIndex { get; set; }
    public int HeightIndex { get; set; }
    public Grid grid { get; set; }
}

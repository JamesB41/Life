using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface INeighborCreator
{
    public void GetNeighbor(Cell CurrentCell, Grid CurrentGrid);
}

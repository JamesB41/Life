using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BottomNeighbor : INeighborCreator
{
    public void GetNeighbor(Cell CurrentCell, Grid CurrentGrid)
    {
        if (CurrentCell._HeightIndex < CurrentGrid.Height - 1)
        {
            Row row = CurrentGrid.Rows[CurrentCell._HeightIndex + 1];
            Cell cell = row.Cells[CurrentCell._WidthIndex];
            CurrentCell._Neighbors.Add(cell);
        }
        if(CurrentCell._HeightIndex == CurrentGrid.Height - 1)
        {
            Row row = CurrentGrid.Rows[0];
            Cell cell = row.Cells[CurrentCell._WidthIndex];
            CurrentCell._Neighbors.Add(cell);
        }
    }
}
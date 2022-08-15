using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenerateGrid
{
    private INeighborCreator[] CellNeighbors = { new TopLeftNeighbor(), new TopNeighbor(), new TopRightNeighbor(), new LeftNeighbor(), new RightNeighbor(), new BottomRightNeighbor(), new BottomNeighbor(), new BottomRightNeighbor() };
    public Grid grid;

    public void Generate(int width, int height)
    {
        grid = new Grid(width, height);

        for(int i = 0; i < height; i++)
        {
            Row row = new Row();
            grid.Rows.Add(row);
            for(int j = 0; j < width; j++)
            {
                Cell cell = new Cell(true, j, i);
                row.Cells.Add(cell);
            }
        }
    }

    public void GenerateNeighbors(Cell cell)
    {
        foreach(INeighborCreator NeighborCreator in CellNeighbors)
        {
            NeighborCreator.GetNeighbor(cell, grid);
        }
    }
}

public class Grid
{
    public List<Row> Rows = new();

    public Grid(int height, int width)
    {
        for (int i = 0; i < height; i++)
        {
            this.Rows.Add(new Row(width));
        }
    }

    public void Iterate()
    {
        for (int row = 0; row < this.Rows.Count; row++) 
        {
            for (int col = 0; col < this.Rows[row].Cells.Count; col++) {
                int aliveNeighbors = GetAliveNeighborCount(row, col);

                Cell currentCell = this.Rows[row].Cells[col];

                // Any live cell with fewer than two live neighbours dies, as if by underpopulation.
                // Any live cell with two or three live neighbours lives on to the next generation.
                // Any live cell with more than three live neighbours dies, as if by overpopulation.
                // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                if (currentCell.IsAlive && aliveNeighbors < 2)
                {
                    currentCell.IsAliveNextRound = false;
                } else if (currentCell.IsAlive && aliveNeighbors > 3)
                {
                    currentCell.IsAliveNextRound = false;
                } else if (currentCell.IsAlive && aliveNeighbors >= 2 && aliveNeighbors <= 3)
                {
                    currentCell.IsAliveNextRound = true;
                } else if (currentCell.IsAlive == false && aliveNeighbors == 3)
                {
                    currentCell.IsAliveNextRound = true;
                }
            }
        }

        // We've determined the next round state of each cell, now apply it.
        foreach(Row r in this.Rows)
        {
            foreach(Cell cell in r.Cells)
            {
                cell.IsAlive = cell.IsAliveNextRound;
                cell.IsAliveNextRound = false;
            }
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

    private int GetAliveNeighborCount(int row, int col)
    {
        int aliveNeighbors = 0;
        int gridWidth = getHeight();
        int gridHeight = getWidth();

        // Above
        aliveNeighbors += this.Rows[(row - 1 >= 0) ? row - 1 : gridHeight - 1].Cells[(col - 1 >= 0) ? col - 1 : gridWidth - 1].IsAlive ? 1 : 0;
        aliveNeighbors += this.Rows[(row - 1 >= 0) ? row - 1 : gridHeight - 1].Cells[col].IsAlive ? 1 : 0;
        aliveNeighbors += this.Rows[(row - 1 >= 0) ? row - 1 : gridHeight - 1].Cells[(col + 1 >= gridWidth) ? 0 : col + 1].IsAlive ? 1 : 0;

        // Left and Right
        aliveNeighbors += this.Rows[row].Cells[(col - 1 >= 0) ? col - 1 : gridWidth - 1].IsAlive ? 1 : 0;
        aliveNeighbors += this.Rows[row].Cells[(col + 1 >= gridWidth) ? 0 : col + 1].IsAlive ? 1 : 0;

        // Below
        aliveNeighbors += this.Rows[(row + 1 >= gridHeight) ? 0 : row + 1].Cells[(col - 1 >= 0) ? col - 1 : gridWidth - 1].IsAlive ? 1 : 0;
        aliveNeighbors += this.Rows[(row + 1 >= gridHeight) ? 0 : row + 1].Cells[col].IsAlive ? 1 : 0;
        aliveNeighbors += this.Rows[(row + 1 >= gridHeight) ? 0 : row + 1].Cells[(col + 1 >= gridWidth) ? 0 : col + 1].IsAlive ? 1 : 0;

        return aliveNeighbors;
    }
}
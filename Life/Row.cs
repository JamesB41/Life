public class Row
{
    public List<Cell> Cells = new List<Cell>();
    
    public Row(int width)
    {
        for (int i = 0; i < width; i++)
        {
            this.Cells.Add(new Cell(this));
        }
    }
}

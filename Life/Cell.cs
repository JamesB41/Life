public class Cell
{
    public bool IsAlive { get; set; }
    public bool IsAliveNextRound { get; set; }
    public Row Row { get; set; }

    public Cell(Row row)
    {
        this.Row = row;
    }
}

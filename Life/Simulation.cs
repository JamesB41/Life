using Life.Patterns;

class Simulation
{
    public static void StartSimulation()
    {
        Grid grid = new(50, 50);
        AddPatternToGrid(new Pulsar(), ref grid, 5, 5);
        AddPatternToGrid(new Pulsar(), ref grid, 25, 5);
        AddPatternToGrid(new Pulsar(), ref grid, 5, 25);
        AddPatternToGrid(new Pulsar(), ref grid, 25, 25);

        while(true)
        {
            Simulation.DrawSimulation(grid);
            grid.Iterate();
        }
    }

    public static void AddPatternToGrid(Pattern p, ref Grid g, int x_pos, int y_pos)
    {
        int pattern_left = x_pos;
        int pattern_top = y_pos;

        foreach (var position in p.getPattern())
        {
            g.Rows[pattern_top + position.Item1].Cells[pattern_left + position.Item2].IsAlive = true;
        }
    }

    private static void DrawSimulation(Grid grid)
    {
        string Life = "";
        foreach(Row row in grid.Rows)
        {
            foreach(Cell cell in row.Cells)
            {
                Life += cell.IsAlive ? "\u25A0 " : "  ";
            }
            Life += "\n";
        }

        Console.SetCursorPosition(0, Console.WindowTop);
        System.Threading.Thread.Sleep(250);

        Console.Write(Life.TrimEnd('\n'));
    }
}

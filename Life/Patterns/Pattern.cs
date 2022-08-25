namespace Life.Patterns
{
    public class Pattern
    {
        public String TextShape;

        public List<Tuple<int, int>> getPattern()
        {
            int row = 0;

            var pattern = new List<Tuple<int, int>>();

            foreach (String line in TextShape.Split("\n"))
            {
                for (int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                    {
                        pattern.Add(new Tuple<int, int>(row, col));
                    }
                }

                row++;
            }

            return pattern;
        }
    }
}

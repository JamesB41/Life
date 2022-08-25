namespace Life.Patterns
{
    public class Tumbler : Pattern
    {
        public Tumbler()
        {
            TextShape += " #     # " + Environment.NewLine;
            TextShape += "# #   # #" + Environment.NewLine;
            TextShape += "#  # #  #" + Environment.NewLine;
            TextShape += "  #   #  " + Environment.NewLine;
            TextShape += "  ## ##  " + Environment.NewLine;
        }
    }
}

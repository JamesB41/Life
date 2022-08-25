namespace Life.Patterns
{
    public class Glider : Pattern
    {
        public Glider()
        {
            TextShape += " # " + Environment.NewLine;
            TextShape += "  #" + Environment.NewLine;
            TextShape += "###" + Environment.NewLine;
        }
    }
}

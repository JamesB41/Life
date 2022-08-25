namespace Life.Patterns
{
    using Point = Tuple<int, int>;

    public class Pulsar : Pattern
    {
        public Pulsar()
        {
            TextShape += "  ###   ###  " + Environment.NewLine;
            TextShape += "             " + Environment.NewLine;
            TextShape += "#    # #    #" + Environment.NewLine;
            TextShape += "#    # #    #" + Environment.NewLine;
            TextShape += "#    # #    #" + Environment.NewLine;
            TextShape += "  ###   ###  " + Environment.NewLine;
            TextShape += "             " + Environment.NewLine;
            TextShape += "  ###   ###  " + Environment.NewLine;
            TextShape += "#    # #    #" + Environment.NewLine;
            TextShape += "#    # #    #" + Environment.NewLine;
            TextShape += "#    # #    #" + Environment.NewLine;
            TextShape += "             " + Environment.NewLine;
            TextShape += "  ###   ###  " + Environment.NewLine;
        }
    }
}

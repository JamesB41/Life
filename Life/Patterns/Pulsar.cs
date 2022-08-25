using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

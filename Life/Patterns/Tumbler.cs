using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

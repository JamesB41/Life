using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Patterns
{
    public class Pattern
    {
        public int width { get; set; }
        public int height { get; set; }

        public List<Tuple<int, int>>? pattern { get; set; }
    }
}

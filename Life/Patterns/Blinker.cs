using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Patterns
{
    internal class Blinker : Pattern
    {
        public Blinker()
        {
            this.width = 3;
            this.height = 1;

            var pattern = new List<Tuple<int, int>>();
            pattern.Add(new Tuple<int, int>(0, 0));
            pattern.Add(new Tuple<int, int>(0, 1));
            pattern.Add(new Tuple<int, int>(0, 2));

            this.pattern = pattern;
        }
    }
}

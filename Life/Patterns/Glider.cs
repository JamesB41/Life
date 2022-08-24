using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Patterns
{
    public class Glider : Pattern
    {
        public Glider()
        {
            this.width = 3;
            this.height = 3;

            var pattern = new List<Tuple<int, int>>();
            pattern.Add(new Tuple<int, int>(0, 0));
            pattern.Add(new Tuple<int, int>(0, 1));
            pattern.Add(new Tuple<int, int>(0, 2));
            pattern.Add(new Tuple<int, int>(1, 0));
            pattern.Add(new Tuple<int, int>(2, 1));

            this.pattern = pattern;
        }
    }
}

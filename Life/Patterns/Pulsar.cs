using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Patterns
{
    internal class Pulsar : Pattern
    {
        public Pulsar()
        {
            this.width = 13;
            this.height = 13;

            var pattern = new List<Tuple<int, int>>();

            pattern.Add(new Tuple<int, int>(0, 2));
            pattern.Add(new Tuple<int, int>(0, 3));
            pattern.Add(new Tuple<int, int>(0, 4));
            pattern.Add(new Tuple<int, int>(0, 8));
            pattern.Add(new Tuple<int, int>(0, 9));
            pattern.Add(new Tuple<int, int>(0, 10));

            pattern.Add(new Tuple<int, int>(2, 0));
            pattern.Add(new Tuple<int, int>(2, 5));
            pattern.Add(new Tuple<int, int>(2, 7));
            pattern.Add(new Tuple<int, int>(2, 12));

            pattern.Add(new Tuple<int, int>(3, 0));
            pattern.Add(new Tuple<int, int>(3, 5));
            pattern.Add(new Tuple<int, int>(3, 7));
            pattern.Add(new Tuple<int, int>(3, 12));

            pattern.Add(new Tuple<int, int>(4, 0));
            pattern.Add(new Tuple<int, int>(4, 5));
            pattern.Add(new Tuple<int, int>(4, 7));
            pattern.Add(new Tuple<int, int>(4, 12));

            pattern.Add(new Tuple<int, int>(5, 2));
            pattern.Add(new Tuple<int, int>(5, 3));
            pattern.Add(new Tuple<int, int>(5, 4));
            pattern.Add(new Tuple<int, int>(5, 8));
            pattern.Add(new Tuple<int, int>(5, 9));
            pattern.Add(new Tuple<int, int>(5, 10));

            pattern.Add(new Tuple<int, int>(7, 2));
            pattern.Add(new Tuple<int, int>(7, 3));
            pattern.Add(new Tuple<int, int>(7, 4));
            pattern.Add(new Tuple<int, int>(7, 8));
            pattern.Add(new Tuple<int, int>(7, 9));
            pattern.Add(new Tuple<int, int>(7, 10));

            pattern.Add(new Tuple<int, int>(8, 0));
            pattern.Add(new Tuple<int, int>(8, 5));
            pattern.Add(new Tuple<int, int>(8, 7));
            pattern.Add(new Tuple<int, int>(8, 12));

            pattern.Add(new Tuple<int, int>(9, 0));
            pattern.Add(new Tuple<int, int>(9, 5));
            pattern.Add(new Tuple<int, int>(9, 7));
            pattern.Add(new Tuple<int, int>(9, 12));

            pattern.Add(new Tuple<int, int>(10, 0));
            pattern.Add(new Tuple<int, int>(10, 5));
            pattern.Add(new Tuple<int, int>(10, 7));
            pattern.Add(new Tuple<int, int>(10, 12));

            pattern.Add(new Tuple<int, int>(12, 2));
            pattern.Add(new Tuple<int, int>(12, 3));
            pattern.Add(new Tuple<int, int>(12, 4));
            pattern.Add(new Tuple<int, int>(12, 8));
            pattern.Add(new Tuple<int, int>(12, 9));
            pattern.Add(new Tuple<int, int>(12, 10));

            this.pattern = pattern;
        }
    }
}

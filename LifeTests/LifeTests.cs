using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Life.Patterns;

namespace LifeTests
{
    [TestClass]
    public class LifeTests
    {
        [TestMethod]
        public void TestBlinker()
        {
            Pattern p = new Blinker();

            Grid grid = new(30, 30);

            int pattern_left = 5;
            int pattern_top = 5;

            foreach (var position in p.pattern)
            {
                grid.Rows[pattern_top + position.Item1].Cells[pattern_left + position.Item2].IsAlive = true;
            }

            // Just iterate once to make sure it rotates
            grid.Iterate();

            Assert.IsTrue(grid.Rows[pattern_top - 1].Cells[pattern_left + 1].IsAlive);
            Assert.IsTrue(grid.Rows[pattern_top].Cells[pattern_left + 1].IsAlive);
            Assert.IsTrue(grid.Rows[pattern_top + 1].Cells[pattern_left + 1].IsAlive);
        }
    }
}
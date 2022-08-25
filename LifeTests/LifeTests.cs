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

            foreach (var position in p.getPattern())
            {
                grid.Rows[pattern_top + position.Item1].Cells[pattern_left + position.Item2].IsAlive = true;
            }

            // Iterate once to make sure it rotates
            grid.Iterate();

            Assert.IsTrue(grid.Rows[pattern_top - 1].Cells[pattern_left + 1].IsAlive);
            Assert.IsTrue(grid.Rows[pattern_top].Cells[pattern_left + 1].IsAlive);
            Assert.IsTrue(grid.Rows[pattern_top + 1].Cells[pattern_left + 1].IsAlive);

            // Should be back to starting state after this
            grid.Iterate();

            Assert.IsTrue(grid.Rows[pattern_top].Cells[pattern_left].IsAlive);
            Assert.IsTrue(grid.Rows[pattern_top].Cells[pattern_left + 1].IsAlive);
            Assert.IsTrue(grid.Rows[pattern_top].Cells[pattern_left + 2].IsAlive);
        }
    }
}
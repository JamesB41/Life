using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTests
{
    [TestClass]
    public class LifeTests
    {
        [TestMethod]
        public void TestCellNeighbors()
        {
            GridFactory gridFactory = new GridFactory();
            Grid FirstGenGrid = gridFactory.Generate(20, 20);

            FirstGeneration FirstGen = new FirstGeneration();
            FirstGenGrid = FirstGen.Generation(FirstGenGrid);

            int expectedHeight = 19;
            int expectedWidth = 19;

            List<Cell> CellList = FirstGenGrid.Rows[0].Cells[0]._Neighbors;
            foreach (Cell cell in CellList)
            {
                if(expectedHeight == cell._HeightIndex && expectedHeight == cell._WidthIndex)
                    Assert.AreEqual(expectedHeight, cell._HeightIndex);
            }
        }

    }
}
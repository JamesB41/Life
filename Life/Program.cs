using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* RULES
 * 
 * 1. Any live cell with fewer than two live neighbours dies
 * 
 * 2. Any live cell with more than three live neighbours dies
 * 
 * 3. Any live cell with two or three live neighbours lives, unchanged, to the next generation
 * 
 * 4. Any dead cell with exactly three live neighbours comes to life.
 * 
 * */

class Program
{
    static void Main(string[] args)
    {
        
        Console.OutputEncoding = Encoding.UTF8;
        /*Console.Title = "Yo";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" \u2580 ");
        Console.ResetColor();*/

        /*Console.WriteLine("Enter the Height: ");
        int Height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Width: ");
        int Width = Convert.ToInt32(Console.ReadLine());

        Grid grid = new Grid(Width, Height);
        grid.CreateRows();

        foreach(Row row in grid.Rows)
        {
            foreach(Cell cell in row.Cells)
            {
                Console.Write(cell.CellBody);
            }
            Console.WriteLine();
        }

        int runs = 0;
        Simulation sim = new Simulation();
*/
        int maxGens = 4;
        int runs = 0;
        GridFactory gridFactory = new GridFactory();
        Grid grid = gridFactory.Generate(10, 10);

        Simulation simulation = new Simulation();

        while (runs++ < maxGens)
        {
            simulation.StartSimulation(grid);
            System.Threading.Thread.Sleep(1000);
        }


        Console.ReadKey();
    }
}
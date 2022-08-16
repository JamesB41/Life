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
 
        int maxGens = 500;
        Simulation sim = new Simulation();
        sim.StartSimulation(maxGens);


        Console.ReadKey();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medailles_Opdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, wat is jouw naam?");
            String input = Console.ReadLine();
            Console.WriteLine("Dat is perfect! Wat is jouw leeftijd?");
            String leefTijd = Console.ReadLine();
            Console.WriteLine("Leuk om je te ontmoeten, " + input + "!" + " " + "Als het goed is, ben jij " + leefTijd + "!");
        }
    }
}

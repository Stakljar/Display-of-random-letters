using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_of_random_letters
{
    internal static class Utilities
    {
        public static void ConfigureConsole()
        {
            Console.Title = "Random letter generator";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
        }
        public static void GenerateThreads()
        {
            ThreadStart threadStart = new ThreadStart(DisplayOperations.Print);
            List<Thread> printingThreads = new List<Thread>();
            for (int i = 0; i < 20; i++)
            {
                printingThreads.Add(new Thread(DisplayOperations.Print));
                printingThreads[i].Start();
            }


            Thread clearConsoleThread = new Thread(new ThreadStart(DisplayOperations.ClearConsole));
            clearConsoleThread.Start();
            Thread checkForResizesThread = new Thread(new ThreadStart(DisplayOperations.CheckIfConsoleResized));
            checkForResizesThread.Start();
        }
    }
}

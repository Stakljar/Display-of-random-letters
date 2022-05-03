using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_of_random_letters
{
    internal class DisplayOperations
    {
        static readonly Random random = new();
        static int initialWidth = Console.WindowWidth;
        public static void ClearConsole()
        {
            while (true)
            {
                Thread.Sleep(2 * 60 * 1000);
                Console.Clear();
            }
        }
        public static void Print()
        {
            int y = 0;
            while (true)
            {
                Console.SetCursorPosition(1 + random.Next(Console.WindowWidth + 1 - 3), y++);
                Console.Write((Char)(65 + random.Next(90 - 65 + 1)));
                Thread.Sleep(50);
            }
        }
        public static void CheckIfConsoleResized()
        {
            try
            {
                while (true)
                {
                    if (Console.WindowWidth - initialWidth != 0)
                    {
                        throw new WindowResizedException("WindowResizedException: Do not change console window width!",
                            Console.WindowWidth, Console.WindowHeight, Console.WindowWidth - initialWidth);
                    }
                }
            }
            catch (WindowResizedException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(1);
            }
        }
    }
}

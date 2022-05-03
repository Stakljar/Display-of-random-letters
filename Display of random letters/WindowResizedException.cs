using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_of_random_letters
{
    internal class WindowResizedException: Exception
    {
        private int windowWidth;
        private int windowHeight;
        private int widthDifference;
        public WindowResizedException(string message, int windowWidth, int WindowHeight, int widthDifference) : base(message)
        {
            this.windowWidth = windowWidth;
            this.windowHeight = WindowHeight;
            this.widthDifference = widthDifference;
        }
        public override string ToString()
        {
            return $"\n{base.Message}" + Environment.NewLine + $"Console window width changed by {Math.Abs(widthDifference)}." +
                Environment.NewLine + $"New console window width: {windowWidth}, height: {windowHeight}.";
        }
    }
}

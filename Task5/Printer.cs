using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Printer
    {
        protected ConsoleColor color;

        public Printer(ConsoleColor color)
        {
            this.color = color;
        }

        public virtual void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: Створити клас Printer. 
    У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу. 
    Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, 
    та виклику відповідного методу їх екземпляра, рядки, передані як аргументи методів, 
    виводилися різними кольорами. Обов'язково використовуйте типи.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter print = new ColorPrinter(ConsoleColor.Yellow);
            print.Print("Hello");

            Printer printUp = print;
            printUp.Print("Hello");

            ColorPrinter print1 = new ColorPrinter(ConsoleColor.Red);
            print1.Print("Hello");

            // Delay.
            Console.ReadKey();
        }
    }
}

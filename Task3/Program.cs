using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створити клас Vehicle.
    У тілі класу створіть поля: координати і параметри засобів пересування (ціна, швидкість, рік випуску).
    Створіть 3 похідних класу Plane, саг і Ship.
    Для класу Plane повинна бути визначена висота і кількість пасажирів.
    Для класу Ship - кількість пасажирів і порт приписки.
    Написати програму, яка виводить на екран інформацію про кожного засобі пересування.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(50000, 300, 2000) { Passengers = 28, Port = "Одесса" };
            Plane plane = new Plane(60000, 1000, 1999) { Hight = 10000, Passengers = 147 };
            Car car = new Car(10000, 200, 2020);
            Console.WriteLine("Швидкiсть корабля {0}, цiна {1}, рiк випуску {2}, кiлькiсть пасажирiв {3}, порт приписки {4}",
                ship.Speed, ship.Price, ship.Year, ship.Passengers, ship.Port);
            Console.WriteLine("Швидкiсть лiтака {0}, цiна {1}, рiк випуску {2}, висота {3} кiлькiсть пасажирiв {4}", 
                plane.Speed, plane.Price, plane.Year, plane.Hight, plane.Passengers);
            Console.WriteLine("Швидкiсть авто {0}, цiна {1}, рiк випуску {2}", car.Speed, car.Price, car.Year);

            // Delay.
            Console.ReadKey();
        }
    }
}

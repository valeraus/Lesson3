using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
     Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створити клас, що представляє навчальний клас ClassRoom.
    Створіть клас учень Pupil. У тілі класу створіть методи void Study (), void Read (), void Write (), void Relax ().
    Створіть 3 похідних класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil 
    і перевизначите кожен з методів, в залежності від успішності учня.
    Конструктор класу ClassRoom приймає аргументи типу Pupil, клас повинен складатися з 4 учнів.
    Передбачте можливість того, що користувач може передати 2 або 3 аргументу.
    Виведіть інформацію про те, як все учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати.
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcelentPupil();

            ClassRoom clas = new ClassRoom(p1, p2);

            clas.Study();
            Console.WriteLine(new string('-', 30));
            clas.Read();
            Console.WriteLine(new string('-', 30));
            clas.Write();
            Console.WriteLine(new string('-', 30));
            clas.Relax();

            Console.ReadKey();
        }
    }
}

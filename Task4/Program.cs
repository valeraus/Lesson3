﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application, 
    потрібно створити клас DocumentWorker. 
    У тілі класу створіть три методи OpenDocument(), EditDocument(), SaveDocument(). 
    У тіло кожного з методів додайте виведення на екран відповідних рядків: 
    "Документ відкритий", "Редагування документа у версії Про", "Збереження документа у версії Про".

    Створіть похідний клас ProDocumentWorker. 
    Перевизначте відповідні методи, при перевизначенні методів виводьте наступні рядки: 
    "Документ відредаговано", "Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт".
    Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker. 
    Перевизначте відповідний спосіб. При викликі даного методу необхідно виводити на екран 
    "Документ збережений у новому форматі".
    У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp. 
    Якщо користувач не вводить ключ, він може користуватися лише безкоштовною версією 
    (створюється екземпляр базового класу), якщо користувач ввів номери ключа доступу pro і exp, 
    то повинен створити екземпляр відповідної версії класу, наведений до базового - DocumentWorker.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть ключ");
            string key = Console.ReadLine();
            DocumentWorker doc = null;

            switch (key)
            {
                case "pro":
                    doc = new ProDocumentWorker();
                    break;
                case "exp":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    Console.WriteLine("Ключ невiрний");
                    doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}

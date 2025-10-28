using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_One
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            string labName = "ЛАБОРАТОРНАЯ РАБОТА 1. РАЗРАБОТКА КОНСОЛЬНОГО ПРИЛОЖЕНИЯ";
            string studentName = "Трунин Иван Дмитриевич";
            string group = "ИДБ-23-01";
            string specialtyCode = "09.03.01";
            string birthDate = "16.10.2005";
            string residence = "Лыткарино";
            string favoriteSubject = "Информатика";
            string hobbies = "Игра на электро и бас гитаре";

            Console.WriteLine($"Название и номер лабораторной работы: {labName}");
            Console.WriteLine($"ФИО: {studentName}");
            Console.WriteLine($"Группа и шифр специальности: {group} {specialtyCode}");
            Console.WriteLine($"Дата рождения: {birthDate}");
            Console.WriteLine($"Населенный пункт: {residence}");
            Console.WriteLine($"Любимый предмет в школе: {favoriteSubject}");
            Console.WriteLine($"Краткое описание увлечений, хобби, интересов: {hobbies}");
            Console.WriteLine();



            // задание 2
            int a_1 = 123;
            double b = 369.14;
            float x = 2.634F, y = 1.354F;

            float answer = a_1 + (float)b - a_1 * (x + y);
            Console.WriteLine($"Ответ: {answer}");



            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.YaroslavtsevMG.Lab2.Review.V6.Lib;

namespace Tyuiu.YaroslavtsevMG.Lab2.Review.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Ярославцев М.Г. | МКМб-22-1";
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                        *");
            Console.WriteLine("* Лабораторная раюота #2                                                         *");
            Console.WriteLine("* Вариант #6                                                                     *");
            Console.WriteLine("* Выполнил: Ярославцев Матвей Геннадьевич | МКМб-22-1                            *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Условие:                                                                       *");
            Console.WriteLine("* Написать программу, которая выводит значение функции (произвести табулирование)*");
            Console.WriteLine("* f(x) на заданном диапазоне X1, X2. Произвести проверку деления на ноль.        *");
            Console.WriteLine("* Значения должны храниться в массиве. Округлить до двух знаков после запятой.   *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Исходные данные:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Старт шага = ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Конец шага = ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Результат:                                                                     *");
            Console.WriteLine("+--------+--------+                                                               ");
            Console.WriteLine("|   X    |  f(x)  |                                                               ");
            Console.WriteLine("+--------+--------+                                                               ");
            double[] res= ds.GetMassFunction(a, b);
            for(int i=0; i<10; i++) 
            {
            Console.WriteLine($"|   {a+i*((double)(b-a)/10)}    |  {res[i]}  |                                                               ");
            }
            Console.WriteLine("+--------+--------+                                                               ");
            Console.ReadKey();


        }
    } 
}

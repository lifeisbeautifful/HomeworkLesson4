using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, в которой создайте две целочисленные
    переменные и задайте им некоторые значения.Применяя технику вложенных циклов, нарисуйте прямоугольник из звездочек.
    Используйте значения ранее созданных переменных для указания высоты и ширины прямоугольника*/
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 7;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

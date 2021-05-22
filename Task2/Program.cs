using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет выводить на экран таблицу умножения на 3.*/

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("3 * {0} = {1}",i,i*3);
            }
            Console.ReadLine();
        }
    }
}

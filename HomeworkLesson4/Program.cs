using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет выводить на экран числа от 1 до 5.  Написать три варианта реализации (while, do...while, for).
    */

    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 5)
            {
                counter++;
                Console.WriteLine(counter);
            }
            Console.WriteLine("*");

            counter = 0;
            do
            {
                counter++;
                Console.WriteLine(counter);
            } while (counter < 5);
            Console.WriteLine("*");

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

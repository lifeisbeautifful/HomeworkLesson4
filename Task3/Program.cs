﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
   /* Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой даны натуральные числа от 20 до 50. Вывести на консоль те из них, которые делятся на 3, 
   но не делятся на 5.*/

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i < 51; i++)
            {
                if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("*");

            int counter = 20;
            while (counter < 51)
            {
                if(counter % 3== 0 && counter % 5 != 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
            Console.ReadLine();

        }
    }
}

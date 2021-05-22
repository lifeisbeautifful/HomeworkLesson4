using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, где пользователь вводит любое целое положительное число.А программа суммирует все числа от 1 до введенного
    пользователем числа.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer greater than zero: ");
            int enteredNumber = int.Parse(Console.ReadLine());

            while (enteredNumber < 1)
            {
                Console.Write("Enter an integer greater than zero: ");
                enteredNumber = int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int sumOfNumbers = 0;

            while (counter <= enteredNumber)
            {
                sumOfNumbers += counter;
                counter++;
            }

            Console.WriteLine("The sum of numbers till {0} = {1}",enteredNumber,sumOfNumbers);
            Console.ReadLine();
        }
    }
}

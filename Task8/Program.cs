using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, которая выводит на экран столько 
    элементов ряда Фибоначчи, сколько указал пользователь.Например, если на ввод поступило число 6, то вывод должен содержать 
    шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13. (Числа Фибоначчи -  элементы числовой последовательности, в которой 
    первые два числа равны либо 1 и 1, либо 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел, например 
    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89).*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer greater than zero to display the Fibonacci sequence: ");
            int enteredNumber = int.Parse(Console.ReadLine());

            while (enteredNumber < 0)
            {
                Console.Write("Choose a positive number: ");
                enteredNumber = int.Parse(Console.ReadLine());
            }

            int firstNumber = 1;
            int secondNumber = 1;

            if (enteredNumber == 0)
            {
                Console.WriteLine(0);
            }
            else if (enteredNumber == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else if (enteredNumber == 2)
            {
                Console.Write(firstNumber + ", " + secondNumber);
            }
            else
            {
                Console.Write(firstNumber+", "+secondNumber);

             for (int i = 3; i <= enteredNumber; i++)
                {
                    int numbersSum = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = numbersSum;
                    Console.Write(", "+secondNumber);
                }
            }
            Console.ReadLine();
        }
    }
}

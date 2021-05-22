using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, в которой запросите пользователя 
    ввести два числа A и B (A<B), если (A>B выведите соответствующее предупреждение) и выведите суму всех чисел расположенных 
    между данными числами на экран.Дано два числа A и B(A<B) выведите все нечетные значения, расположенные между данными числами*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values to A and B. A should be less than B");
            Console.Write("A = ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("B = ");
            int B = int.Parse(Console.ReadLine());
            
            if (A > B)
            {
                int sumOfNumbers = 0;

                Console.WriteLine("A is greater than B");

                for (int i = B+1; i < A; i++)
                {
                    sumOfNumbers += i; 
                }

                Console.WriteLine("The sum of numbers between A and B = {0} ",sumOfNumbers);
            }else if (A < B)
            {
                for (int i = A+1; i < B; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i+", ");
                    }
                }
            }
            else
            {
                Console.WriteLine("A = B");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет рассчитывать сумму вклада в банк.Процентную ставку, сумму и срок на которой положили вклад, 
    должен вводить пользователь с клавиатуры.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());

            while (depositAmount - (int)depositAmount != 0||depositAmount < 0)
            {
                Console.Write("Enter an integer greater than zero: ");
                depositAmount = double.Parse(Console.ReadLine());
            }

            Console.Write("Enter the deposit term: ");
            int depositTerm = int.Parse(Console.ReadLine());

            while (depositTerm < 0)
            {
                Console.Write("Enter positive number: ");
                depositTerm = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the interest rate of the deposit: ");
            double depositRate = double.Parse(Console.ReadLine());

            while (depositRate < 0)
            {
                Console.Write("Enter positive number: ");
                depositRate = double.Parse(Console.ReadLine());
            }

            double interestPerMonth = (depositAmount * depositRate / 100)/12;
            depositAmount+= interestPerMonth * depositTerm;
            Console.WriteLine("You will have {0} on your account in the end of deposit term",Math.Round(depositAmount,2));
            Console.ReadLine();
        }
    }
}

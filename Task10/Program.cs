using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет складывать, вычитать, умножать или делить два числа.Числа и знак операции вводятся пользователем. 
    После выполнения вычисления программа не должна завершаться, а должна запрашивать новые данные для вычислений.Завершение 
    программы должно выполняться при вводе символа '0' в качестве знака операции. Если пользователь вводит неверный знак 
    (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об ошибке и снова запрашивать знак операции.Также сообщать 
    пользователю о невозможности деления на ноль, если он ввел 0 в качестве делителя*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter operand 1: ");
            double operand1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operand 2: ");
            double operand2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the sign of the arithmetic operation or press zero to exit: ");
            string sign = Console.ReadLine();
            

            while (sign != "0")
            {
                while(sign!="+" && sign!="-" && sign!="*" && sign != "/")
                {
                    Console.Write("Enter the sign of the arithmetic operation(+, -, *, /): ");
                    sign = Console.ReadLine();
                }
                switch (sign)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}",operand1,operand2,Math.Round(operand1+operand2,2)); 
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}",operand1,operand2,Math.Round(operand1-operand2,2));
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}",operand1,operand2,Math.Round(operand1*operand2,2));
                        break;
                    case "/":
                        while (operand2 == 0)
                        {
                            Console.Write("Error, you are trying divide by zero!Choose another value for operand 2: ");
                            operand2 = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("{0} / {1} = {2}",operand1,operand2,Math.Round(operand1/operand2,2));
                        break;
                }
                Console.Write("Enter operand 1: ");
                operand1 = double.Parse(Console.ReadLine());

                Console.Write("Enter operand 2: ");
                operand2 = double.Parse(Console.ReadLine());

                Console.Write("Enter the sign of the arithmetic operation or press zero to exit: ");
                sign = Console.ReadLine();
            }
            Console.WriteLine("You have logged out of the program");
            Console.ReadLine();
        }
    }
}

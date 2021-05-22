using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, которая поможет первокласнику 
    Пети, у которого  m рублей .Мороженое стоит k рублей. Петя решил наесться досыта мороженого, для этого он покупал по одному 
    мороженому и съедал его до тех пор, пока ему хватало денег. Как Пете узнать, сколько денег останется у него в конце концов? 
    учтите, что петя делить еще не умеет, а умеет только вычитать и складывать. сколько мороженых он может съесть?.*/
    class Program
    {
        static void Main(string[] args)
        {
            double m = 126.87;
            double k = 5.5;
            int counter = 0;

            while (m - k >= 0)
            {
                m = m - k;
                counter++;
            }

            Console.Write("Will eat {0} ice creams, {1} money will left",counter,Math.Round(m,2));
            Console.ReadLine();
        }
    }
}

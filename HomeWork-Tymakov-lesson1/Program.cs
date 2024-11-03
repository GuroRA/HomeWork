using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Tymakov_lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Лабораторная 2.1: Написать программу, которая спрашивает имя пользователя,
               и затем приветствует пользователя по имени. (Создат консольное приложение.)
            */
            Console.WriteLine("Упражнение 2.1 из лабораторной Тумакова");

            Console.WriteLine("what's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"AYO what's up {userName}");


            /* Лабораторная 2.2: Написать программу, которой на вход подается два
               целых числа, на выходе – результат деления одного числа на другое.
               Предусмотреть обработку исключительной ситуации, возникающей при
               делении числа на ноль.
            */
            Console.WriteLine("Упражнение 2.2 из лабораторной Тумакова");

            Console.WriteLine("Please enter two numbers");
            float firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (secondNumber != 0)
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                Console.WriteLine("The second number must not equal to 0");
            }


            /* Домашка 2.1: Прочитать букву с экрана и вывести на печать
               следующую за ней букву в алфавитном порядке. 
            */

            Console.WriteLine("Упражнение 2.1 из домашки Тумакова");

            Console.WriteLine("Enter the letter:");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Convert.ToChar(letter+1));



            /* Домашка 2.2: Написать программу, которая решает квадратное
               уравнение. Входные данные – коэффициенты уравнения, выходные –
               найденные корни. 
            */

            Console.WriteLine("Упражнение 2.2 из домашки Тумакова");

            Console.WriteLine("Enter the coefficients:");
            float a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToInt32(Console.ReadLine());
            float c = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                double Discriminant = b * b - 4 * a * c;
                double x1 = (-b + Math.Sqrt(Discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(Discriminant)) / 2 * a;
                Console.WriteLine($"First result {x1}");
                Console.WriteLine($"Second result {x2}");
            }
            else if (b != 0){
                float x = c / b;
                Console.WriteLine($"Result {x}");
            }
            else {
                Console.WriteLine($"Result {c}");
            }
            Console.ReadKey();
        }
    }
}

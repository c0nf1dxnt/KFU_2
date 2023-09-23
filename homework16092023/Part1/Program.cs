using System;
using System.Text;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1:\nСпросить у пользователя имя и поприветствовать его\n");
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!\n");
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2:\nПолучить на ввод 2 целых числа и вывести резултат деления\n");
            int number1, number2;
            Console.Write("Введите 2 целых числа:\nЧисло №1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число №2: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 != 0 && number2 != 0)
            {
                Console.WriteLine("Результат деления числа 1 на число 2 равен: " + (Convert.ToDecimal(number1) / number2) + "\n");
            }
            else
            {
                Console.WriteLine("Деление на 0!\n");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3\nПолучить одну букву русского/английского алфавита и вывести букву следующую за ней\n");
            Console.Write("Введите любую букву русского/английского алфавита: ");
            char value = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Следующая буква по русскому/английскому алфавиту: {(char)((int)value + 1)}\n");
        }
        static void Task4()
        {
            Console.WriteLine("Задание №4:\nПолучить на ввод коэффициенты квадратного уравнения и вывести его корни, если они есть\n");
            Console.Write("Введите коэффициент \"a\" квадратного уравнения: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"b\" квадратного уравнения: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"c\" квадратного уравнения: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((b * b - 4 * a * c) < 0)
            {
                Console.WriteLine("Корней нет\n");
            }
            else if ((b * b - 4 * a * c) == 0)
            {
                Console.WriteLine("Один корень");
                Console.WriteLine("x = " + (-b / (2 * a)) + "\n");
            }
            else
            {
                Console.WriteLine("Два корня:");
                Console.WriteLine("x1 = " + (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                Console.WriteLine("x2 = " + ((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)) + "\n");
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Тумаков, лабораторная работа 2 главы\n");

            Task1();
            Task2();
            Task3();
            Task4();

            Console.ReadKey();
        }
    }
}
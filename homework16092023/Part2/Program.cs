using System;
using System.Text;

namespace Part2
{
    internal class Program
    {
        enum TypesOfAccount
        {
            SavingsAccountBalance = 17000,
            CurrentAccountBalance = 7000
        }
        struct BankAccount
        {
            public int AccountNumber;
            public string AccountType;
            public int AccountBalance;
        }
        enum Universities
        {
            КФУ,
            КАИ,
            КХТИ
        }   
        struct Employee
        {
            public string Name;
            public Universities University;
        }
        static void Task1()
        {
            Console.WriteLine("Задание №1:\nСоздать перечислимый тип данных отображающий виды банковского\r\nсчета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей\r\nзначение и вывести это значение на печать.\n");
            TypesOfAccount Balance = new TypesOfAccount();
            Balance = TypesOfAccount.CurrentAccountBalance;
            Console.WriteLine($"Баланс счёта: {Balance}, равен: {(int)Balance}₽\n");
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2:\nСоздать структуру данных, которая хранит информацию о банковском\r\nсчете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру\r\nзначениями и напечатать результат.");
            BankAccount Account = new BankAccount();
            Account.AccountNumber = 147824;
            Account.AccountType = "Сберегательный счёт";
            Account.AccountBalance = 70000;
            Console.WriteLine($"\nНомер счёта: {Account.AccountNumber}\n" +
                $"Тип счёта: {Account.AccountType}\nБаланс счёта: {Account.AccountBalance}₽\n");
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3:\nСоздать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать\r\nструктуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и\r\nраспечатать.\n");
            Employee Person = new Employee();
            Universities University = Universities.КФУ;
            Person.Name = "Владимир Ульянов";
            Person.University = University;
            Console.WriteLine($"Имя: {Person.Name}\nУниверситет: {Person.University}");

        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Тумаков, лабораторная работа 3 главы\n");

            Task1();
            Task2();
            Task3();

            Console.ReadKey();
        }
    }
}
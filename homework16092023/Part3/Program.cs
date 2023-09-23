using System;
using System.Text;
using System.Threading;

namespace Part3
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1:\nВывести информацию о каждом типе данных в формате\nТип данных\tМаксимальное значение\t\tМинимальное значение\n");
            Console.WriteLine($"float\t\t{float.MaxValue}\t\t\t{float.MinValue}");
            Console.WriteLine($"double\t\t{double.MaxValue}\t\t{double.MinValue}");
            Console.WriteLine($"decimal\t\t{decimal.MaxValue}\t{decimal.MinValue}");
            Console.WriteLine($"byte\t\t{byte.MaxValue}\t\t\t\t{byte.MinValue}");
            Console.WriteLine($"sbyte\t\t{sbyte.MaxValue}\t\t\t\t{sbyte.MinValue}");
            Console.WriteLine($"short\t\t{short.MaxValue}\t\t\t\t{short.MinValue}");
            Console.WriteLine($"ushort\t\t{ushort.MaxValue}\t\t\t\t{ushort.MinValue}");
            Console.WriteLine($"int\t\t{int.MaxValue}\t\t\t{int.MinValue}");
            Console.WriteLine($"uint\t\t{uint.MaxValue}\t\t\t{uint.MinValue}");
            Console.WriteLine($"long\t\t{long.MaxValue}\t\t{long.MinValue}");
            Console.WriteLine($"ulong\t\t{ulong.MaxValue}\t\t{ulong.MinValue}\n");
            Console.WriteLine("Тип char может содержать любой символ в кодировке Unicode");
            Console.WriteLine("Тип bool имеет лишь два значения: True и False");
            Console.WriteLine("Тип string может содержать любую последовательность символов в кодировке Unicode\n");

        }
        struct UserData
        {
            public string Name;
            public int Age;
            public int PinCode;
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2:\nНапишите программу, в которой принимаются данные пользователя в виде имени,\r\nгорода, возраста и PIN-кода. Далее сохраните все значение в соответствующей\r\nпеременной, а затем распечатайте всю информацию в правильном формате.\r\n");
            UserData user1 = new UserData();
            Console.Write("Введите имя: ");
            user1.Name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            user1.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите PIN-код: ");
            user1.PinCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nДанные пользователя:\nИмя пользователя: {user1.Name}\nВозраст пользователя: {user1.Age}\nPIN-код пользователя: {user1.PinCode}\n");
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3:\nПреобразовать строку, заменив строчные буквы на заглавные и наоборот\n");
            Console.Write("Введите строку: ");
            string InputString = Console.ReadLine();
            string Answer = "";
            for (int i = 0; i < InputString.Length; i++)
            {
                if (char.IsUpper(InputString[i]))
                {
                    Answer += char.ToLower(InputString[i]);
                }
                else
                {
                    Answer += char.ToUpper(InputString[i]);
                }
            }
            Console.WriteLine($"Получилась строка: {Answer}\n");
        }
        static void Task4()
        {
            Console.WriteLine("Задание №4:\nНайти количество вхождений подстроки в строку и вывести это число на экран\n");
            Console.Write("Введите строку: ");
            string InputString = Console.ReadLine();
            Console.Write("Введите подстроку:");
            string InputSubstring = Console.ReadLine();
            Console.WriteLine("Подстрока входит в строку " + ((InputString.Length - InputString.Replace(InputSubstring, "").Length) / InputSubstring.Length) + " раз\n");
        }
        static void Task5()
        {
            Console.WriteLine("Задание №4:\nЦель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам\r\nнужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически\r\nпокрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),\r\nскидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка\r\nобычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы\r\nсэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов\r\nстерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут\r\nцелыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону\n");
            Console.Write("Введите стоимость одной бутылки виски(в фунтах стерлингов): ");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер скидки (в процентах): ");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расходы на отпуск(в фунтах стерлингов): ");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double answer = normPrice * Convert.ToDouble(salePrice) / 100 * holidayPrice;
            Console.WriteLine($"Для покрытия расходов на отпуск требуется выпить {Math.Floor(answer)} бутылок виски\n");
        }
        static void Task6()
        {
            Console.WriteLine("Задание №6:\nВоспроизвести разговор Гарри Поттера и дневника Тома Реддла. Пользователь\r\nздоровается с консолью. Консоль спрашивает, как зовут пользователя. Пользователь\r\nназывает имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь\r\nспрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да». После\r\nэтого пользователь спрашивает, может ли рассказать. Консоль отвечает «Нет». Спустя 5\r\nсекунд консоль дополняет «но могу показать». Консоль меняет цвет на любой случайный\r\nцвет.\r\n");
            Console.Write("Гарри Поттер: ");
            string UserInput = Console.ReadLine();
            Console.Write("Том Реддл: Как тебя зовут?\nГарри Поттер: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Том Реддл: Привет, {Name}!\nГарри Поттер: Знаешь ли ты что-нибудь о тайной комнате?");
            Console.WriteLine("Том Реддл: Да\nГарри Поттер: Можешь ли ты рассказать о ней?\nТом Реддл: Нет");
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write("Но могу показать...");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine('\n');
        }
        static void Task7()
        {
            Console.WriteLine("Задание №7:\nВычислить контрольную цифру штрихкода (EAN13)\r\n12 цифр определяются случайным образом.\r\n12 цифр вводит пользователь\n");
            Random random = new Random();
            string RandomCode = "";
            while (RandomCode.Length != 12)
            {
                RandomCode += random.Next(0, 10);
            }
            Console.WriteLine($"Сгенерированный код: {RandomCode}");
            int SumOfEvenNumbers1 = 0,
                SumOfOddNumbers1 = 0,
                SumOfEvenNumbers2 = 0,
                SumOfOddNumbers2 = 0;
            Console.Write("Введите ваш код: ");
            string InputCode = Console.ReadLine();
            for (int i = 1; i < 13; i += 2)
            {
                SumOfEvenNumbers1 += (int)(RandomCode[i] - '0');
                SumOfEvenNumbers2 += (int)(InputCode[i] - '0');
            }
            for (int i = 0; i < 12; i += 2)
            {
                SumOfOddNumbers1 += (int)(RandomCode[i] - '0');
                SumOfOddNumbers2 += (int)(InputCode[i] - '0');
            }
            int SumOfValues = SumOfEvenNumbers1 * 3 + SumOfOddNumbers1;
            int SumOfValues2 = SumOfEvenNumbers2 * 3 + SumOfOddNumbers2;
            int ControlNumberRandom = SumOfValues + (10 - (SumOfValues % 10)) - SumOfValues,
                ControlNumberInput = SumOfValues2 + (10 - (SumOfValues2 % 10)) - SumOfValues2;
            Console.WriteLine($"Контрольное число случайного кода: {ControlNumberRandom}");
            Console.WriteLine($"Контрольное число введённого кода: {ControlNumberInput}");
        }
        struct Student
        {
            public string Surname;
            public string Name;
            public int ID;
            public string DateOfBirth;
            public char AlcoStatus;
            public double AlcoValue;
        }
        static void Task8()
        {
            Console.WriteLine("Задание №8:\nСоздать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата\r\nрождения, Категория алкоголизма (SumOfEvenNumbers – студент алкоголик, SumOfOddNumbers – студент любитель\r\nвыпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у\r\nстудента есть Объем выпитого алкоголя. Создать 5 студентов с различными\r\nпараметрами. Посчитать общий объем алкоголя и кто сколько процентов выпил.\n");
            Student[] students = new Student[5];
            students[0] = new Student {Surname = "Орехов", Name = "Пётр", ID = 1, DateOfBirth = "12.12.2000", AlcoStatus = 'A', AlcoValue = 15};
            students[1] = new Student {Surname = "Кагарлицкий", Name = "Владимир", ID = 2, DateOfBirth = "28.11.1998", AlcoStatus = 'B', AlcoValue = 10};
            students[2] = new Student {Surname = "Примарк", Name = "Евгений", ID = 3, DateOfBirth = "09.08.1999", AlcoStatus = 'C', AlcoValue = 5};
            students[3] = new Student {Surname = "Усов", Name = "Ростисав", ID = 4, DateOfBirth = "01.05.1999", AlcoStatus = 'D', AlcoValue = 0};
            students[4] = new Student {Surname = "Шаломов", Name = "Марк", ID = 5, DateOfBirth = "19.09.1998", AlcoStatus = 'D', AlcoValue = 0};
            double SumOfAlco = 0;
            for (int i = 0; i < 5; i++)
            {
                SumOfAlco += students[i].AlcoValue;
            }
            Console.WriteLine($"Общее количество выпитого студентами алкоголя в год составляет {SumOfAlco} литров");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{students[i].Surname} {students[i].Name} выпил {students[i].AlcoValue} литров алкоголя за год, что составило {(students[i].AlcoValue / SumOfAlco) * 100:F1}% от всего выпитого студентами алкоголя");
            }
        }
            static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();

            Console.ReadKey();
        }
    }
}

using System;
using System.Text;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            string str = Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string symbols = "!@#$%^&*()_+-=[]{}|;:,.<>?";
            string digits = "0123456789";
            int randomIndex;
            char randomchar;




            //Pasword(rnd, abc, ABC, symbols, digits);
            //RandomSpecChars(rnd, symbols, out randomIndex, out randomchar);
            //Random10Symb(rnd, ABC, out randomIndex, out randomchar);
            //RandomEngAlphSymb(abc, out randomIndex, out randomchar);
            //RandomSymbol(rnd, str);
            //RandomIndex(str);
            //Random();
            //Chislo0To1();
            //ChislaMinus5To5(rnd);
            //Slojeniechisel(rnd);

            Console.ReadKey();


        }
        /// <summary>
        /// пароль(но я не понял кака его делать правильно полностью)
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="abc"></param>
        /// <param name="ABC"></param>
        /// <param name="symbols"></param>
        /// <param name="digits"></param>
        private static void Pasword(Random rnd, string abc, string ABC, string symbols, string digits)
        {
            int pl = rnd.Next(8, 16);

            StringBuilder password = new StringBuilder();

            password.Append(abc[rnd.Next(abc.Length)]);
            password.Append(ABC[rnd.Next(ABC.Length)]);
            password.Append(digits[rnd.Next(digits.Length)]);
            password.Append(symbols[rnd.Next(symbols.Length)]);
        }

        /// <summary>
        /// 15 случайных спец символов (закоментировал т.к. ошибка при извлечении)
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="symbols"></param>
        /// <param name="randomIndex"></param>
        /// <param name="randomchar"></param>
        //private static void RandomSpecChars(Random rnd, string symbols, out int randomIndex, out char randomchar)
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        randomIndex = rnd.Next(0, symbols.Length);
        //        randomchar = symbols[randomIndex];
        //        Console.Write(randomchar);
        //    }
        //}

        /// <summary>
        /// 10 случайных символов латинского алфавита (закоментировал т.к. ошибка при извлечении)
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="ABC"></param>
        /// <param name="randomIndex"></param>
        /// <param name="randomchar"></param>
        //private static void Random10Symb (Random rnd, string ABC, out int randomIndex, out char randomchar)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        randomIndex = rnd.Next(0, ABC.Length);
        //        randomchar = ABC[randomIndex];
        //        Console.WriteLine($"случайный символ английского алфавита {randomchar}");
        //    }
        //}

        /// <summary>
        /// вывод случайного символа латинского алфавита
        /// </summary>
        /// <param name="abc"></param>
        /// <param name="randomIndex"></param>
        /// <param name="randomchar"></param>
        private static void RandomEngAlphSymb(string abc, out int randomIndex, out char randomchar)
        {
            randomIndex = new Random().Next(0, abc.Length);
            randomchar = abc[randomIndex];
            Console.Write($"случайный символ английского алфавита {randomchar}");
        }

        /// <summary>
        /// случайный символ из строки 
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="str"></param>
        private static void RandomSymbol(Random rnd, string str)
        {
            str.Split(' ');
            Console.WriteLine(str);

            int index = rnd.Next(0, str.Length);
            char c = str[index];
            Console.WriteLine($"Случайный символ: {c}");
        }
        /// <summary>
        /// вывод случайного слова строки 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string RandomIndex(string str)
        {
            str = str.Replace(" ", "");
            Console.WriteLine("Строка после удаления пробелов: " + str);

            int randomIndex = new Random().Next(0, str.Length);
            char randomChar = str[randomIndex];

            Console.WriteLine("Случайный символ: " + randomChar);
            return str;
        }
        /// <summary>
        /// от 100 до -100 вычислить сумму и кол-во
        /// </summary>
        /// <param name="rnd"></param>
        //private static void Slojeniechisel(Random rnd)
        //{
        //    int y = 0;
        //    double z = 0;
        //    for (int i = 0; i < 10; i++)
        //    {

        //        double x = rnd.NextDouble() * 100 + (-50);
        //        Console.WriteLine($"{x:F4}");
        //        if (x < 0)
        //        {
        //            y++;
        //            z += x;


        //        }


        //    }
        //    Console.WriteLine($"Сумма отрицательных элементов={z}");
        //    Console.WriteLine($"Кол-во отрицательных элементов={y}");
        //}

        /// <summary>
        /// 10 чисел от -5 до 5
        /// </summary>
        /// <param name="rnd"></param>
        //private static void ChislaMinus5To5(Random rnd)
        //{
        //    for (int i = 10 - 1; i >= 0; i--)
        //    {
        //        double x = rnd.NextDouble() * 10 + (-5);
        //        Console.WriteLine($"{x:F4}");
        //    }
        //}

        /// <summary>
        /// вывод 10 чисел от 0 до 1(дробных)
        /// </summary>
        //private static void Chislo0To1(Random rnd)
        //{

        //    for (int i = 0; i < 10; i++)
        //    {
        //        double x = rnd.NextDouble() * 10 + (-5);
        //        Console.WriteLine(x);
        //    }
        //}

        /// <summary>
        /// вывод 10 случайных чисел
        /// </summary>
        //private static void Random(Random rnd)
        //{

        //    for (int i = 0; i < 10; i++)
        //    {

        //        int x = rnd.Next(1, 10);
        //        Console.WriteLine(x);

        //    }
    }
}

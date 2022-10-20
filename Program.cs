using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа по определению четного или нечетного числа!");
            Console.WriteLine("Введите число:");

            int N = int.Parse(Console.ReadLine());

            int remainder = N % 2;
            if (remainder == 0)
                Console.WriteLine("Вы ввели четное число");
            else
                Console.WriteLine("Вы ввели нечетное число");


            Console.ReadKey(true);

        }
    }
}

using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Dzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1

            Console.WriteLine("задание 1:");
            int number;
            while (true)
            {
                Console.Write("введите целое четырехзначное число: ");
                if (!int.TryParse(Console.ReadLine(), out number) || number < 1000 || number > 9999)
                {
                    Console.WriteLine("ошибка | число не четырехзначное или не целое");
                }
                else
                {
                    break;
                }
            }
            int count = 0;
            for (int i = number; i > 0; i /= 10)
            {
                if ((i % 10) % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"количество четных цифр в числе {number} равно: {count}");



            //2
            ulong sumarry = 0;
            int a;
            int b;
            Console.WriteLine("введите число а (англискую): ");
            while (true)
                if (!int.TryParse((Console.ReadLine()), out a))
                {
                    Console.WriteLine("неккоректный ввод | введите целое число а");
                }
                else
                {
                    break;
                }
            Console.WriteLine("введите число б (англискую): ");
            while (true)
            {
                if (!int.TryParse((Console.ReadLine()), out b) || a > b)
                {
                    Console.WriteLine("неккоректный ввод | введите целое число б. Также б должно быть больше а");
                }
                else
                {
                    break;
                }
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    sumarry += (ulong)(i * i);
                }
            }
            Console.WriteLine($"сумма квадратов целых нечетных чисел от а до б равна: {sumarry}");



            //3
            Console.WriteLine("введите пароль: ");
            const int correctpassword = 12345;
            int password;
            int attempts = 5;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out password) && password == correctpassword)
                {
                    Console.WriteLine("дарова");
                    return;
                }
                else
                {
                    if (attempts > 1)
                    {
                        attempts--;
                        Console.WriteLine($"ошибка | пароль неверный {attempts}");
                    }
                    else
                    {
                        Console.WriteLine("лимит | больше нельзя");
                        return;
                    }
                }
            }


        }
    }
}
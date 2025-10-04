using System.Collections.Generic;

namespace Dzz
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //1

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Random.Shared.Next(7, 15);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                {
                    numbers[i] = numbers[i] - 10;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            //2
            int[] numbers1 = Array.ConvertAll(new int[20],
                 _ => Random.Shared.Next(10, 31));

            int[] numbers2 = Array.ConvertAll(new int[20],
              _ => Random.Shared.Next(10, 31));

            int[] numbers3 = new int[20];
            Console.Write("\nсуммы соответствующих элементов 2 массивов: ");
            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = numbers1[i] + numbers2[i];
            }
            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.Write($"{numbers3[i]} ");
            }
            double average = 0;
            for (int i = 0; i < numbers3.Length; i++)
            {
                average += (double)numbers3[i] / 2;
            }

            Console.WriteLine($"\nсреднее арифметическое элементов 3 массива: {average}");

            int MinValue = numbers3[0];
            int MaxValue = numbers3[0];
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (numbers3[i] < MinValue)
                {
                    MinValue = numbers3[i];
                }
                if (numbers3[i] > MaxValue)
                {
                    MaxValue = numbers3[i];
                }
            }

            Console.WriteLine($"минимальное значение 3 массива: {MinValue}");
            Console.WriteLine($"максимальное значение 3 массива: {MaxValue}");

            //3 
            int[] numbers4 = Array.ConvertAll(new int[20],
                _ => Random.Shared.Next(0, 51));
            Console.Write("элементы неотсортированного 4 массива: ");
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.Write($"{numbers4[i]} ");
            }

            for (int i = 0; i < numbers4.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < numbers4.Length - i - 1; j++) 
                {
                    if (numbers4[j] < numbers4[j + 1])
                    {
                        int temp = numbers4[j];
                        numbers4[j] = numbers4[j + 1];
                        numbers4[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break; 
            }

            Console.Write("элементы отсортированного 4 массива: ");
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.Write($"{numbers4[i]} ");
            }
        }
    }
}
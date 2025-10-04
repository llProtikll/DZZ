namespace Dzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1

            Console.WriteLine("1");
            int[,] matrix = new int[3, 5];
            Console.WriteLine("введите элементы матрицы:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.WriteLine("ошибка | введите целое число");
                    }
                }
            }
            Console.WriteLine("визуал матрицы:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 1; i == 1 || i == 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine($"сумма элементов 2 и 3 строк матрицы равна: {sum}");
            
            //2

            Console.WriteLine("2");
            int[,] matrix2 = new int[4, 4];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = Random.Shared.Next(10, 101);
                }
            }

            Console.WriteLine($"элементы матрицы равны: ");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"{matrix2[i, j]}\t");
                }
                Console.WriteLine();
            }

            int[] arraysumline = new int[matrix2.GetLength(0)];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    arraysumline[i] += matrix2[i, j];
                }
            }

            int maxValue = arraysumline[0];
            int maxIndex = 0;
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                if (arraysumline[i] > maxValue)
                {
                    maxValue = arraysumline[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"наибольшая сумма строки матрицы равна - {maxValue} ном строки {maxIndex + 1}");
            
            //3

            Console.WriteLine("3");
            int[,] matrix3 = new int[4, 4];
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    matrix3[i, j] = Random.Shared.Next(-100, 101);
                }
            }

            Console.WriteLine("элементы матрицы равны: ");
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.Write($"{matrix3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("положительные элементы главной диагонали матрицы: ");
            
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                if (matrix3[i, i] >= 0)
                {
                    Console.Write($"{matrix3[i, i]}\t");
                }
            }

            Console.WriteLine("\nположительные элементы второстепенной диагонали матрицы: ");

            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                if (matrix3[i, matrix3.GetLength(1) - i - 1] > 0)
                {
                    Console.Write($"{matrix3[i, matrix3.GetLength(1) - i - 1]}\t");
                }
            }
        }
    }
}
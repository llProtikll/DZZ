namespace Dzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("имя:");
            string name = Console.ReadLine();
            Console.WriteLine("годиков:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("рост:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("гендер (м/ж):");
            string gender = Console.ReadLine();
            Console.WriteLine("буква:");
            char letter = char.Parse(Console.ReadLine());
            Console.WriteLine("город:");
            string city = Console.ReadLine();

            Console.WriteLine($"имя: {name}");
            Console.WriteLine($"годиков: {age}");
            Console.WriteLine($"рост: {height}");
            Console.WriteLine($"гендер (м/ж): {gender}");
            Console.WriteLine($"буква: {letter}");
            Console.WriteLine($"город: {city}");
        }
    }
}
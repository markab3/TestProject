using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Map newMap = new Map(10);
            Console.WriteLine("Hello World!");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}

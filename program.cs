using System;

namespace codeacademycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# is a strongly typed language");
            Console.WriteLine();
            Console.WriteLine("Type anything into the console and I'll try to figure out what it is so you can begin to learn datatypes.");
            string strang = Console.ReadLine();
            Console.WriteLine($"{strang} is a string");
        }
    }
}

using System;
using System.IO;
using System.Linq;

namespace app
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Wpisz ilość linii do pominięcia:");
            var skipCount = int.Parse(Console.ReadLine());
            
            var lines = File.ReadAllLines("input.txt")
                .Skip(skipCount).ToArray();

            try
            {
                var parsed = Parser.Parse(lines)
                    .ToArray();

                Console.WriteLine(parsed.Length);
            }
            catch (ParserException exception)
            {
                Console.WriteLine($"ERROR: Unable to parse line {exception.Line + skipCount}.");
            }

            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}

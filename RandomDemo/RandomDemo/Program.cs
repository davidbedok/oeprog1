using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDemo
{
    class Program
    {
        private static void Main(string[] args)
        {
            Random rand = new Random();
            Program.testCreateRandomNumbers(rand);
            Program.testCreateRandomOrderedNumbers(rand);
            Program.testCreateRandomNumbersWithoutDuplicates(rand);
            Console.ReadKey();
        }

        private static void testCreateRandomNumbers(Random rand)
        {
            Console.WriteLine("# Create random numbers");
            int[] numbers = Generator.createRandomNumbers(rand, 10, 500);
            Console.WriteLine(Arrays.toString(numbers));
        }

        private static void testCreateRandomOrderedNumbers(Random rand)
        {
            Console.WriteLine("# Create random ordered numbers");
            int[] numbers = Generator.createRandomOrderedNumbers(rand, 10);
            Console.WriteLine(Arrays.toString(numbers));
        }

        private static void testCreateRandomNumbersWithoutDuplicates(Random rand)
        {
            Console.WriteLine("# Create random numbers without duplicates");
            int[] data = Generator.createRandomNumbersWithoutDuplicates(rand, 10, 100);
            Console.WriteLine(Arrays.toString(data));
            int[] numbers = Generator.createRandomNumbersWithoutDuplicates(rand, 10, 10);
            Console.WriteLine(Arrays.toString(numbers));
        }

    }
}

using System;

namespace Excercise_31___32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 8, 0, 24, 51 };
            {
                Console.WriteLine("Please enter an index number, 0-4. ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"The number at index {input} is {nums}");
            }
        }


    }
}

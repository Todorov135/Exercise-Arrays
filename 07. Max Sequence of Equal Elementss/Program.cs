using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elementss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int maxCount = int.MinValue;
            int number = 0;

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                }
                else 
                {
                    count = 0;
                }
                
                if (maxCount <= count)
                {
                    maxCount = count;
                    number = input[i];
                }
            }
            for (int i = 0; i <= maxCount; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}

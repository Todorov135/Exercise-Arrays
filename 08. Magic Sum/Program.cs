using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                int firstNum = input[i];
                for (int j = i+1; j < input.Length; j++)
                {
                    int secondNum = input[j];

                    if (firstNum + secondNum == magicNum)
                    {
                        Console.WriteLine(firstNum + " " + secondNum);
                    }

                }
            }

        }
    }
}

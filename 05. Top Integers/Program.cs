using System;
using System.Linq;

namespace _05.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length ; i++)
            {
                 bool isTopInteger = true;

                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[i]<= inputArr[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{inputArr[i]} ");
                }

            }
        }
    }
}

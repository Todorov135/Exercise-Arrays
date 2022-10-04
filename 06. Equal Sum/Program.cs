using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr.Length == 1)
                {
                    Console.WriteLine(0);

                    return;
                }
                

                sumLeft = 0;

                for (int j = i; j > 0; j--)
                {
                    int leftElement = j - 1;
                    if (j > 0)
                    {
                        sumLeft += inputArr[leftElement];
                    }

                }
                sumRight = 0;
                for (int k = i; k < inputArr.Length; k++)
                {
                    int rightElement = k + 1;
                    if (k < inputArr.Length-1)
                    {
                        sumRight += inputArr[rightElement];
                    }
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}

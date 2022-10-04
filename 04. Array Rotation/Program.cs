using System;
using System.Linq;

namespace _04.Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < rotation; i++)
            {
                int tempEl = inputArr[0];

                for (int j = 0; j < inputArr.Length-1; j++)
                {
                    inputArr[j] = inputArr[j + 1];
                }
                inputArr[inputArr.Length-1] = tempEl;

            }
            Console.WriteLine(String.Join(" ", inputArr));
        }
    }
}

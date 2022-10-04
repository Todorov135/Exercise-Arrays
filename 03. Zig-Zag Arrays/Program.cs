using System;
using System.Linq;

namespace _03.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            int[] firstLine = new int[numOfLines]; 
            int[] secondLine = new int[numOfLines];

            for (int i = 0; i < numOfLines; i++)
            {
                int[] currLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstLine[i] = currLine[0];
                    secondLine[i] = currLine[1];
                }
                else
                {
                    firstLine[i] = currLine[1];
                    secondLine[i] = currLine[0];

                }

            }

            Console.WriteLine(String.Join(" ", firstLine));
            Console.WriteLine(String.Join(" ", secondLine));
           
        }
    }
}

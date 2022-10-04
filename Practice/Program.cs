using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i <= rotation; i++)
            {   
                int tempEl = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1]; 

                }
                input[input.Length-1] = tempEl;

            }
            Console.WriteLine(string.Join(" ", input));
            
               
        }
    }
}

using System;
using System.Linq;

namespace _02.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ');
            string[] secondInput = Console.ReadLine().Split(' ');

            foreach (string currNumFromFirst in firstInput)
            {
                for (int i = 0; i < secondInput.Length; i++)
                {
                    string currNumFromSecond = secondInput[i];
                    if (currNumFromFirst == currNumFromSecond)
                    {
                        Console.Write($"{currNumFromFirst} ");
                    }
                }
            }

            
            
        }
    }
}

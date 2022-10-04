using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] personsInWagons = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < personsInWagons.Length; i++)
            {

                personsInWagons[i] = int.Parse(Console.ReadLine());
                sum += personsInWagons[i];
            }
            Console.WriteLine(String.Join(" ", personsInWagons));
            Console.WriteLine(sum);
        }
    }
}

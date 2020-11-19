using System;

namespace MauroGay_SwapArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = { 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Array 1 position {i} before swap: {array1[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"Array 2 position {i} before swap: {array2[i]}");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array2[i];
                Console.WriteLine($"Array 1 position {i} after swap: {array1[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
                Console.WriteLine($"Array 2 position {i} after swap: {array1[i]}");
            }
        }
    }
}

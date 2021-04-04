using System;

namespace ClassLibrary1
{
    public class Swapping
    {
        public static void SwapMyArray(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Array 1 position {i} before swap: {array1[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Array 2 position {i} before swap: {array2[i]}");
            }

            int[] array11 = new int[5];
            int[] array22 = new int[5];
            array11 = array1;
            array22 = array2;

            array2 = array11;
            array1 = array22;

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Array 1 position {i} after swap: {array1[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"Array 2 position {i} after swap: {array2[i]}");
            }
        }
    }
}

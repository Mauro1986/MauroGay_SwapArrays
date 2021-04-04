using System;
using ClassLibrary1;

namespace MauroGay_SwapArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = { 6, 5, 4, 3, 2, 1 };

            Swapping.SwapMyArray(array1, array2);
        }
    }


}

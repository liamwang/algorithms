using System;

namespace Algorithms
{
    public static class Utils
    {
        public static int[] GenRandomArray(int length, int maxValue = 999)
        {
            Random rd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = rd.Next(1, maxValue);
            }
            return arr;
        }

        public static void WriteBefore(string algName, int[] arr)
        {
            Console.WriteLine($"{algName} Before: " + string.Join(", ", arr));
        }

        public static void WriteAfter(string algName, int[] arr)
        {
            Console.WriteLine($"{algName}  After: " + string.Join(", ", arr));
            Console.WriteLine();
        }
    }
}

namespace Algorithms
{
    /// <summary>
    /// 插入排序 O(n^2)
    /// </summary>
    public static class InsertionSort
    {
        public static void Execute(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
    }
}

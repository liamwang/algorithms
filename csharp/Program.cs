using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // 插入排序
            int[] arr = Utils.GenRandomArray(10);
            Utils.WriteBefore(nameof(InsertionSort), arr);
            InsertionSort.Execute(arr);
            Utils.WriteAfter(nameof(InsertionSort), arr);

            // 冒泡排序
            arr = Utils.GenRandomArray(10);
            Utils.WriteBefore(nameof(BubbleSort), arr);
            BubbleSort.Execute(arr);
            Utils.WriteAfter(nameof(BubbleSort), arr);

            // 选择排序
            arr = Utils.GenRandomArray(10);
            Utils.WriteBefore(nameof(SelectionSort), arr);
            SelectionSort.Execute(arr);
            Utils.WriteAfter(nameof(SelectionSort), arr);

            Console.ReadLine();
        }
    }
}

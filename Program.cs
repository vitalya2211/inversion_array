using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {//инверсия массива
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int n = arr.Length;
            int k = n / 2;//середина массива
            int temp;
            foreach (int i in arr)
                Console.Write($"{i}\t");
            Console.WriteLine();
            for(int i =0;i<k;i++)
            {
                temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
            foreach (int i in arr)
                Console.Write($"{i}\t");
            Console.WriteLine();
            
            
        }
    }
}

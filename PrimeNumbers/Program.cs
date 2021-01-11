using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number till which we'll be looking for primer numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            FillingArray(arr, n);
            Calcualtion(arr, n);
            Result(arr, n);
            Console.ReadKey();
        }
        static void FillingArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            arr[0] = 0;
        }
        static void Result (int[] arr, int n)
        {
            Console.WriteLine($"Prime numbers from 1 to {n} are:");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0) Console.WriteLine(arr[i]);
            }
        }
        static void Calcualtion(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    for (int k = 2; k < Math.Sqrt(n); k++)
                    {
                        if (arr[i] == k) arr[i] = k;
                        else if (arr[i] % k == 0) arr[i] = 0;
                    }
                }
            }
        }
    }
}

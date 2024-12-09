using System;

class Program
{
    const int MAX = 100;

    static int Sum(int[] arr)
    {
        int result = 0;
        foreach (int num in arr)
        {
            result += num;
        }
        return result;
    }

    static void Main()
    {
        int n = GetNumberOfElements();
        int[] arr = GetArrayElements(n);
        int total = Sum(arr);

        Console.WriteLine("Sum of the numbers: " + total);
    }

    static int GetNumberOfElements()
    {
        int n;
        Console.Write("Enter the number of elements (1-100): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > MAX)
        {
            Console.WriteLine("Invalid input. Please provide a digit ranging from 1 to 100.");
        }
        return n;
    }

    static int[] GetArrayElements(int n)
    {
        int[] arr = new int[n];
        Console.WriteLine("Enter " + n + " integers:");
        for (int i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
        return arr;
    }
}
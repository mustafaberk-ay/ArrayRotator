using System;

public class ArrayRotator
{
    static void RotateArrayLeft(int[] input)
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            int temp = input[i];
            input[i] = input[i + 1];
            input[i + 1] = temp;
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = { 1,2,3,4,5,6 };
        RotateArrayLeft(arr);
        Array.ForEach(arr, Console.WriteLine);
    }
}
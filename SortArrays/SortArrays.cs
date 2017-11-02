using System;

class SortArrays
{
    static void Main()
    {
        int WholeNumber = 5;
        int[] elements = new int[WholeNumber];
        for (int i = 0; i < WholeNumber; i++)
        {
            Console.Write("Number {0} : ", i);
            elements[i] = int.Parse(Console.ReadLine());
        }

        // int elements = {12, 15, 28, 6, ...};

        Array.Sort(elements);
        Array.Reverse(elements);

        Console.WriteLine("Sorted array : ");

        foreach (int element in elements)
        {
            Console.WriteLine(element);
        }
    }
}




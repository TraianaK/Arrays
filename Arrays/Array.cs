using System;

class Array
{
    static void Main()
    {
        string[] myElements = new string[3];
        myElements[0] = Console.ReadLine();
        myElements[1] = Console.ReadLine();
        myElements[2] = Console.ReadLine();

        for (int counter = 0; counter < 3; counter++)
        {
            Console.WriteLine(myElements[counter]);
        }

    }
}
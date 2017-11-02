using System;

    class ConvertStringToNumber
    {
        static void Main()
        {
            char[] phoneNumber = Console.ReadLine().ToCharArray();
            string result = "";
            foreach (char c in phoneNumber)

            {
                if (c == 'a' || c == 'b' || c == 'c')
                {
                    result = result + "2";
                }
                else if (c == 'd' || c == 'e' || c == 'f')
                {
                    result = result + "3";
                }
                else if (c == 'h' || c == 'i' || c == 'g')
                {
                    result = result + "4";
                }
                else if (c == 'k' || c == 'l' || c == 'j')
                {
                    result = result + "5";
                }
                else if (c == 'm' || c == 'n' || c == 'o')
                {
                    result = result + "6";
                }
                else if (c == 'p' || c == 'q' || c == 'r' || c == 's')
                {
                    result = result + "7";
                }
                else if (c == 't' || c == 'u' || c == 'v')
                {
                    result = result + "8";
                }
                else if (c == 'w' || c == 'x' || c == 'y' || c == 'z')
                {
                    result = result + "9";
                }
                else if (c == ' ')
                {
                    result = result + "0";
                }
            }
            Console.WriteLine("The result is : " + result);
        }
    }



// Created By MagmaAracde
// Date: 18/1/23

// reverses the case of each letter for a given word
using System;
namespace Reverse_the_Case
{
    public class Reverse_the_Case
    {
        static string ReverseCase(string str)
        {
            char[] array = str.ToCharArray(); // converts the string into an array where each letter is split

            // if the char is between the lowercase ascii    values, an acii values will be suntracted 
            // to convert to an uppercase letter. else the value is added.
            for (int i=0; i < str.Length; i++)
            {
                if (char.IsUpper(array[i]))
                {
                    array[i] = char.ToLower(array[i]);
                }
                else if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            // Converts the array back into a string so it can be returned
            string reverseString = new string(array);
            return reverseString;
        }


        // Driver Code
        public static void Main()
        {
            Console.WriteLine("Please enter something");
            Console.WriteLine("");
            Console.Write("Input: ");
            string str = Console.ReadLine();

            // Function call
            Console.WriteLine("output: " + ReverseCase(str));
        }
    }
}

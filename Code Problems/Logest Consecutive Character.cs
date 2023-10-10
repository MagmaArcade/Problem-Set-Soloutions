// Created By MagmaAracde
// Date: 9/10/23

// This program is used to identify the longest consecutive substring with single character.
namespace Identify_Longest_Palindromic_Substring
{
    public class Longest_Consecutive_Substring
    {
        public static Tuple<char, int> FindLongestConsecutiveCharacters(string input)
        {
            var maxChar = input[0];

            var max = 1;
            var current = 1;

            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    current++;
                    if (current > max)
                    {
                        max = current;
                        maxChar = input[i];
                    }
                }
                else
                {
                    current = 1;
                }
            }

            return new Tuple<char, int>(maxChar, max);
        }

        // Driver Code
        public static void Main()
        {
            Console.WriteLine("This program is used to identify the longest consecutive substring with single character.");
            /*Console.WriteLine("Please enter your string");
            string word = Console.ReadLine();
            Console.WriteLine();*/

            string word = "efababad";

            // Function call
            Console.WriteLine("output: " + FindLongestConsecutiveCharacters(word));
        }
    }
}
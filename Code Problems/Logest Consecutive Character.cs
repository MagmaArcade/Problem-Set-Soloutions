// Created By MagmaAracde
// Date: 9/10/23

using System;
using System.Text;


// This program is used to identify the longest consecutive substring with single character.
namespace Identify_Longest_Substring
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

        //////////////////////////////////////////////////////////////////////////////////////


        public static void DuplicateChars(string input)
        {
            // Morphic Relations for Transformed List before Function Call
                System.Text.StringBuilder updatedString = new System.Text.StringBuilder(input.Length);

                foreach (char c in input)
                {
                    // Append the updated character to the StringBuilder
                    updatedString.Append(c);
                    updatedString.Append(c);
                    updatedString.Append(c);
                }

                // Get the translated input
                string translatedinput = updatedString.ToString();

                Tuple<char, int> TransformedTuple = FindLongestConsecutiveCharacters(translatedinput);


            // Morphic Relations for Transformed output after Function Call
            // Function call for origional list
            Tuple<char, int> originalTuple = FindLongestConsecutiveCharacters(input);

                // Multiply 3 to the int value
                int newNum = (int)(originalTuple.Item2 * 3);

                // Creating a new tuple with the updated char value
                Tuple<char, int> updatedTuple = new Tuple<char, int>(originalTuple.Item1, newNum);



            Console.WriteLine(FindLongestConsecutiveCharacters(translatedinput));
            Console.WriteLine(updatedTuple);

            bool areEqual = TransformedTuple.Equals(updatedTuple);

            if (areEqual)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
                //Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));
                //Console.WriteLine("output (char, consecutive #): " + updatedTuple);
            }

        }
        public static void NumTransform(string input)
        {
            // Morphic Relations for Transformed List before Function Call

                char[] newChar = new char[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    char currentChar = char.ToLower(input[i]);

                    // Check if the character is a lowercase letter 'a' to 'z'
                    if (currentChar >= 'a' && currentChar <= 'z')
                    {
                        // Map 'a' to 1, 'b' to 2, and so on
                        newChar[i] = (char)(currentChar - 'a' + '1');
                    }
                    if (currentChar >= '1' && currentChar <= '9')
                    {
                        // Map '1' to 'a', '2' to 'b', and so on
                        newChar[i] = (char)(currentChar - '1' + 'a');
                    }

                }

                string translatedinput = string.Join("", newChar);

                Tuple<char, int> TransformedTuple = FindLongestConsecutiveCharacters(translatedinput);

            // Morphic Relations for Transformed output after Function Call
                // Function call for origional list
                Tuple<char, int> originalTuple = FindLongestConsecutiveCharacters(input);

                char charTransform = originalTuple.Item1;

                if (originalTuple.Item1 >= 'a' && originalTuple.Item1 <= 'z')
                {
                    // Map 'a' to 1, 'b' to 2, and so on
                    charTransform = (char)(charTransform - 'a' + '1');
                }
                else if (originalTuple.Item1 >= '1' && originalTuple.Item1 <= '9')
                {
                    // Map '1' to 'a', '2' to 'b', and so on
                    charTransform = (char)(charTransform - '1' + 'a');
                }

                // Creating a new tuple with the updated char value
                Tuple<char, int> updatedTuple = new Tuple<char, int>(charTransform, originalTuple.Item2);


            Console.WriteLine(FindLongestConsecutiveCharacters(translatedinput));
            Console.WriteLine(updatedTuple);

            bool areEqual = TransformedTuple.Equals(updatedTuple);

            if (areEqual)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
                //Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));
                //Console.WriteLine("output (char, consecutive #): " + updatedTuple);
            }


        }
        public static void Reverse(string input)
        {
            // Morphic Relations for untransformed List
                Tuple<char, int> TransformedTuple = FindLongestConsecutiveCharacters(input);


            // Morphic Relations for transformed List
                // Convert the input string to a char array
                char[] charArray = input.ToCharArray();

                // Use StringBuilder to efficiently reverse the char array
                StringBuilder reversedStringBuilder = new StringBuilder();
                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    reversedStringBuilder.Append(charArray[i]);
                }

                // Convert the reversed StringBuilder back to a string
                string translatedinput = reversedStringBuilder.ToString();

                Tuple<char, int> OrigionalTuple = FindLongestConsecutiveCharacters(translatedinput);


            Console.WriteLine(FindLongestConsecutiveCharacters(input));
            Console.WriteLine(FindLongestConsecutiveCharacters(translatedinput));

            bool areEqual = TransformedTuple.Equals(OrigionalTuple);

            if (areEqual)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
                //Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(input));
                //Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));
            }
        }
        public static void CharIncrement(string input)
        {
            // Morphic Relations for Transformed List before Function Call
                System.Text.StringBuilder updatedString = new System.Text.StringBuilder(input.Length);

                foreach (char c in input)
                {
                    // Convert the character to its Unicode value, add 1, and convert it back to a character
                    char updatedChar = (char)(c + 1);

                    // Append the updated character to the StringBuilder
                    updatedString.Append(updatedChar);
                }

                // Get the translated input
                string translatedinput = updatedString.ToString();

                // Function call and print for transformed origional list
            Tuple<char, int> TransformedTuple = FindLongestConsecutiveCharacters(translatedinput);


            // Morphic Relations for Transformed output after Function Call
            // Function call for origional list
            Tuple<char, int> originalTuple = FindLongestConsecutiveCharacters(input);

                // Adding 1 to the char value
                char newChar = (char)(originalTuple.Item1 + 1);

                // Creating a new tuple with the updated char value
                Tuple<char, int> updatedTuple = new Tuple<char, int>(newChar, originalTuple.Item2);


            Console.WriteLine(FindLongestConsecutiveCharacters(translatedinput));
            Console.WriteLine(updatedTuple);

            bool areEqual = TransformedTuple.Equals(updatedTuple);

            if (areEqual)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
               // Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));
               // Console.WriteLine("output (char, consecutive #): " + updatedTuple);
            }
        }




        // Driver Code
        public static void Main()
        {
            Console.WriteLine("This program is used to identify the longest consecutive substring with single character.");

            string input = "aabbbce"; // standard input

            CharIncrement(input);
            Reverse(input);
            NumTransform(input);
            DuplicateChars(input);
            Console.WriteLine("----------------------------------");

            string input2 = "1334442"; // number input

            CharIncrement(input2);
            Reverse(input2);
            NumTransform(input2);
            DuplicateChars(input2);
            Console.WriteLine("------------------------------------------");

            string input3 = "b3ee3b"; // mix input

            CharIncrement(input3);
            Reverse(input3);
            NumTransform(input3);
            DuplicateChars(input3);
        }
    }
}
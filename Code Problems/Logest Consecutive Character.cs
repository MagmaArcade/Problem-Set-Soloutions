// Created By MagmaAracde
// Date: 9/10/23

// This program is used to identify the longest consecutive substring with single character.
namespace Identify_Longest_Palindromic_Substring
{
    public class Longest_Consecutive_Substring
    {
        public class Longest_Consecutive_Substring
        {
            ///////////////////////////////////////////////////////////////////////////////////
            // Original Source Code
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

            public static void DuplicateChars()
            {
                string input = "abceeca"; // Origional input

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
                // Function call and print for transformed origional list

                Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));

                // Morphic Relations for Transformed output after Function Call
                // Function call for origional list
                Tuple<char, int> originalTuple = FindLongestConsecutiveCharacters(input);

                // Multiply 3 to the int value
                int newNum = (int)(originalTuple.Item2 * 3);

                // Creating a new tuple with the updated char value
                Tuple<char, int> updatedTuple = new Tuple<char, int>(originalTuple.Item1, newNum);

                // print the transformed output
                Console.WriteLine("output (char, consecutive #): " + updatedTuple);
            }
            public static void NumTransform()
            {
                string input = "aabbbccd"; // Origional input

                // Morphic Relations for Transformed List before Function Call

                int[] numbers = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    char currentChar = char.ToLower(input[i]);

                    // Check if the character is a lowercase letter 'a' to 'z'
                    if (currentChar >= 'a' && currentChar <= 'z')
                    {
                        // Map 'a' to 1, 'b' to 2, and so on
                        numbers[i] = currentChar - 'a' + 1;
                    }
                    else
                    {
                        // Handle non-alphabet characters (e.g., spaces, punctuation)
                        numbers[i] = 0; // You can choose another value or behavior
                    }
                }

                string translatedinput = string.Join("", numbers);

                Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));


                // Morphic Relations for Transformed output after Function Call
                // Function call for origional list
                Tuple<char, int> originalTuple = FindLongestConsecutiveCharacters(input);

                // Adding 1 to the char value
                char newChar = (char)(originalTuple.Item1 + 1);

                // Convert the character to its corresponding number
                int charAsNumber = originalTuple.Item1 - 'a' + 1;

                // Creating a new tuple with the updated char value
                Tuple<int, int> updatedTuple = new Tuple<int, int>(charAsNumber, originalTuple.Item2);

                // print the transformed output
                Console.WriteLine("output (char, consecutive #): " + updatedTuple);

            }
            public static void Reverse()
            {
                string input = "aabbbccd"; // Origional input

                // Morphic Relations for untransformed List
                Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(input));


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

                Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));
            }
            public static void CharIncrement()
            {
                string input = "aabbbccd"; // Origional input

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
                Console.WriteLine("output (char, consecutive #): " + FindLongestConsecutiveCharacters(translatedinput));


                // Morphic Relations for Transformed output after Function Call
                // Function call for origional list
                Tuple<char, int> originalTuple = FindLongestConsecutiveCharacters(input);

                // Adding 1 to the char value
                char newChar = (char)(originalTuple.Item1 + 1);

                // Creating a new tuple with the updated char value
                Tuple<char, int> updatedTuple = new Tuple<char, int>(newChar, originalTuple.Item2);

                // print the transformed output
                Console.WriteLine("output (char, consecutive #): " + updatedTuple);
            }




            // Driver Code
            public static void Main()
            {
                Console.WriteLine("This program is used to identify the longest consecutive substring with single character.");

                CharIncrement();
                Console.WriteLine("");
                Reverse();
                Console.WriteLine("");
                NumTransform();
                Console.WriteLine("");
                DuplicateChars();
            }
        }
    }
}
// Created By MagmaAracde
// Date: 1/1/23

// This program is used to identify the longest sequence that reads the same backwards as forwards
namespace Identify_Longest_Palindromic_Substring
{
    public class Identify_Longest_Palindromic_Substring
    {
        // Function to obtain the length of the longest palindromic substring
        static int longestPalSubStr(string str)
        {

            string subString;

            // Stores the maximum length
            int maxLength = 1, start = 0;

            // Iterate over the string
            for (int i = 0; i < str.Length; i++)
            {

                // Iterate over the string
                for (int j = i; j < str.Length; j++)
                {
                    int flag = 1;

                    // Check for palindrome
                    for (int k = 0;
                            k < (j - i + 1) / 2; k++)
                        if (str[i + k] != str[j - k])
                            flag = 0;

                    // If string [i, j - i + 1]
                    // is palindromic
                    if (flag != 0 &&
                       (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }

            // Trim the string so only the palindrome remains
            str.Remove(0, start);
            subString = str.Remove(maxLength, str.Length - maxLength);



            // Returns the sub string
            return maxLength;
        }
         

        // Driver Code
        public static void Main()
        {
            Console.WriteLine("This program is used to identify the longest sequence that reads the same backwards as forwards.");
            /*Console.WriteLine("Please enter your string");
            string word = Console.ReadLine();
            Console.WriteLine();*/

            string word = "efababad";

            // Function call
            Console.WriteLine("output: " + longestPalSubStr(word));
        }
    }
}
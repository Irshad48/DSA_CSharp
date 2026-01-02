using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HCL_word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = " abc  def ghi ";
                int countSimpleSplit = CountWordsUsingSimpleSplit(input);
                Console.WriteLine($"Word count using simple split: {countSimpleSplit}");
                int countRemoveEmptyEntries = CountWordsUsingRemoveEmptyEntries(input);
                Console.WriteLine($"Word count using RemoveEmptyEntries: {countRemoveEmptyEntries}");
                int countRegex = CountWordsUsingRegex(input);
                Console.WriteLine($"Word count using Regex: {countRegex}");
                int countManualIteration = CountWordsUsingManualIteration(input);
                Console.WriteLine($"Word count using manual iteration: {countManualIteration}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught expected exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught unexpected exception: {ex.Message}");
            }
        }
        /// <summary>
        /// Counts the number of words in the specified input string using a simple space-based split.
        /// </summary>
        /// <param name="input">The input string to analyze. Cannot be null, empty, or consist only of white-space characters.</param>
        /// <returns>The number of words found in the input string, where words are delimited by spaces.</returns>
        /// <exception cref="ArgumentException">Thrown if the input string is null, empty, or consists only of white-space characters.</exception>
        /// <problems>
        /// does not handle multiple consecutive spaces correctly, leading to inaccurate word counts.
        /// does not trim leading or trailing spaces before counting, which can also lead to incorrect counts.
        /// </problems>
        static int CountWordsUsingSimpleSplit(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }
            int wordCount = 0;
            input = input.Trim();
            wordCount = input.Split(' ').ToList().Count();
            return wordCount;
        }
        /// <summary>
        /// Counts the number of words in the specified string, using spaces as word separators and ignoring empty
        /// entries.
        /// </summary>
        /// <remarks>Consecutive spaces and leading or trailing spaces are ignored when counting words, as empty entries are removed.</remarks>
        /// <param name="input">The input string to analyze. Cannot be null, empty, or consist only of white-space characters.</param>
        /// <returns>The number of words found in the input string. Words are defined as sequences of characters separated by
        /// spaces.</returns>
        /// <exception cref="ArgumentException">Thrown if the input string is null, empty, or consists only of white-space characters.</exception>
        static int CountWordsUsingRemoveEmptyEntries(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }
            int wordCount = 0;
            wordCount = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
        /// <summary>
        /// Counts the number of words in the specified input string using a regular expression.
        /// </summary>
        /// <param name="input">The string to analyze for word count. Cannot be null or empty.</param>
        /// <returns>The number of words found in the input string.</returns>
        /// <exception cref="ArgumentException">Thrown if the input string is null, empty, or consists only of white-space characters.</exception>
        static int CountWordsUsingRegex(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }
            return Regex.Matches(input, @"\b\w+\b").Count;
        }
        /// <summary>
        /// Counts the number of words in the specified string using manual character iteration.
        /// </summary>
        /// <param name="input">The string to analyze for word count. Cannot be null or consist only of white-space characters.</param>
        /// <returns>The number of words found in the input string. Words are defined as sequences of non-white-space characters
        /// separated by white space.</returns>
        /// <exception cref="ArgumentException">Thrown if the input string is null or consists only of white-space characters.</exception>
        static int CountWordsUsingManualIteration(string input)
        {
            int count = 0;
            bool inWord = false;
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }
            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                    inWord = false;
                else if (!inWord)
                {
                    inWord = true;
                    count++;
                }
            }
            return count;
        }
    }
}
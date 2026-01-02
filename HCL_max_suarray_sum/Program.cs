using System;

/// <notes>
/// Possible subarrays are: n(n+1)/2
/// BruteForce: O(n^3) - Check all subarrays and calculate their sums
/// Optimized BruteForce: O(n^2) - Calculate sums using prefix sums
/// Kadane's Algorithm: O(n) - Dynamic programming approach
/// </notes>
namespace HCL_max_suarray_sum
{
   class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine("Array elements are:");
            PrintArray(array);
            Console.WriteLine("Possible Subarrays are:");
            printPossibleSubarrays(array);
            Console.WriteLine(" ==========  Line Seperator  =========");
            
            int maxSum = MaxSubArraySumBruteForce(array);
            Console.WriteLine("Maximum Subarray Sum (Brute Force): " + maxSum);
            int maxSumTest = MaxSubArraySumBruteForceTest(array);
            Console.WriteLine("Maximum Subarray Sum (Brute Force Test): " + maxSumTest);
            int kadaneSum = kadaneAlgorithm(array);
            Console.WriteLine("Maximum Subarray Sum (Kadane's Algorithm): " + kadaneSum);
        }
        /// <summary>
        /// Finds the maximum sum of a contiguous subarray within the specified array of integers using Kadane's
        /// algorithm.
        /// </summary>
        /// <remarks>Kadane's algorithm efficiently computes the maximum subarray sum in linear time. The
        /// input array must contain at least one element for meaningful results.</remarks>
        /// <param name="arr">An array of integers to search for the contiguous subarray with the largest sum. Cannot be null.</param>
        /// <returns>The maximum sum of any contiguous subarray found within the input array. If the array is empty, returns
        /// int.MinValue.</returns>
        static int kadaneAlgorithm(int[] arr)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                currentSum += arr[i];
                maxSum = Math.Max(maxSum, currentSum);
                if(currentSum < 0)
                {
                    currentSum = 0;
                }
            }
            return maxSum;
        }
        /// <summary>
        /// Calculates the maximum sum of any contiguous subarray within the specified array using a brute-force
        /// approach.
        /// </summary>
        /// <remarks>This method examines all possible contiguous subarrays to determine the maximum sum,
        /// resulting in O(n^2) time complexity. For large arrays, consider using a more efficient algorithm such as
        /// Kadane's algorithm.</remarks>
        /// <param name="arr">An array of integers for which the maximum contiguous subarray sum will be computed. Cannot be null.</param>
        /// <returns>The largest sum of any contiguous subarray found within the input array. If the array is empty, returns
        /// int.MinValue.</returns>
        static int MaxSubArraySumBruteForce(int[] arr)
        {
            int maxSum = int.MinValue;
            for (int start = 0; start < arr.Length; start++)
            {
                int currentSum = 0;
                for (int end=start; end < arr.Length; end++)
                {
                    currentSum += arr[end];
                    maxSum = Math.Max(maxSum, currentSum);
                }
            }
            return maxSum;
        }

       
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void printPossibleSubarrays(int[] arr)
        {
            for(int start=0; start<arr.Length; start++)
            {
                for (int end = start; end < arr.Length; end++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        Console.Write(arr[k]);
                    }
                    Console.Write("     ");
                }
                Console.WriteLine();
            }
        }
    }
}
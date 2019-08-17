using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class SubArrayWithZeroSum
    {
        /// <summary>
        /// Checks if an array has any sub array set with a zero sum
        /// </summary>
        /// <param name="array">array to check</param>
        /// <returns>true if there is a sub array with zero sum, false otherwise</returns>
        public static bool Check(int[] array)
        {
            int runningSum = 0;

            // Hash set so we can get an O(n) perf
            HashSet<int> set = new HashSet<int>();
            set.Add(0);     // make sure zero in the first node (potentially only) of the array still works

            for (int i = 0; i < array.Length; i++)
            {
                runningSum += array[i];

                // If the current sum equals a past sum in all the sums we've seen, that means
                // there's some sub array that adds to zero obviously (whatever is between
                // the running sum and the sum in the hash set).
                if (set.Contains(runningSum))
                {
                    return true;
                }

                set.Add(array[i]);
            }

            return false;
        }

        /// <summary>
        /// Find all sub arrays with zero sum (with array order being maintained)
        /// </summary>
        /// <param name="array">array to search for with sub arrays that add to zero</param>
        /// <returns>list of sub arrays that add to zero</returns>
        public static List<int[]> Find(int[] array)
        {
            int runningSum = 0;
            List<int[]> resultList = new List<int[]>();

            // Use running sum idea, but also know the index of the past sum and the current sum. Then we can 
            // splice the array between those two indices to get all the sub arrays with zero sums.
            // Map structure: <sum at index, index>
            Dictionary<int, List<int>> hashMap = new Dictionary<int, List<int>>();

            // Initialize with zero sum in case array starts with zero.
            hashMap.Add(0, new List<int>() { -1 });

            for (int i = 0; i < array.Length; i++)
            {
                runningSum += array[i];

                // Sum already found - build all possible arrays based on the sums we've already seen then add this index to the list for the next potential finding of this sum
                if (hashMap.ContainsKey(runningSum))
                {
                    List<int> previousIndicesWithSum = hashMap[runningSum];
                    foreach (int previousIndexWithSum in previousIndicesWithSum)
                    {
                        // start of the sum array is 1 index after the original finding of the sum to the new index.
                        int startIndex = previousIndexWithSum + 1;
                        int endIndex = i;
                        int newArrayLength = endIndex - startIndex + 1;
                        int[] subArray = new int[newArrayLength];
                        Array.Copy(array, startIndex, subArray, 0, newArrayLength);
                        resultList.Add(subArray);
                    }

                    // Add index for this sum to the list for next time we see this sum
                    hashMap[runningSum].Add(i);
                }
                // Sum not seen yet - initialize a new list for this node 
                else
                {
                    hashMap.Add(runningSum, new List<int>() { i });
                }
            }

            return resultList;
        }
    }
}

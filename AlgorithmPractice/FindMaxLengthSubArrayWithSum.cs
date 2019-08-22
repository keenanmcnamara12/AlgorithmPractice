using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice
{
    public class FindMaxLengthSubArrayWithSum
    {
        public static bool Find(int[] array, int sumToFind, out int[] resultArray)
        {
            // Dictionary<running sum at index, first index seen with running sum>
            Dictionary<int, int> sums = new Dictionary<int, int>();
            sums.Add(0, -1);
            int runningSum = 0;
            int startFound = 0;
            int endFound = 0;
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                runningSum += array[i];

                if (!sums.ContainsKey(runningSum))
                {
                    sums.Add(runningSum, i);
                }
                // Find the sum at a given index
                int runningSumToFind = runningSum - sumToFind;

                // If we've seen the needed running sum to have the existing sum and the length of this array is longer than previous, save.
                if (sums.ContainsKey(runningSumToFind) && i - sums[runningSumToFind] > endFound - startFound)
                {
                    startFound = sums[runningSumToFind] + 1;    // it's the element after the location that we saw the running sum that we care about
                    endFound = i;
                    found = true;
                }
            }

            resultArray = new int[endFound - startFound + 1];
            if (found)
            {
                Array.Copy(array, startFound, resultArray, 0, resultArray.Length);
            }
            return found;
        }
    }
}
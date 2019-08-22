using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice
{
    public class FindLargestSubArrayConsecutiveInt
    {
        public static int[] Find(int[] array)
        {
            // For each array, start a dictionary of the elements
            HashSet<int> hash = new HashSet<int>();
            int startIndexFound = 0;
            int endIndexFound = 0;
            int startIndexTest = 0;
            int endIndexTest = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                if (!hash.Contains(element))
                {
                    // If this is longest, save off the updated indices
                    endIndexTest = i;
                    hash.Add(element);
                    if (endIndexTest - startIndexTest > endIndexFound - startIndexFound)
                    {
                        startIndexFound = startIndexTest;
                        endIndexFound = endIndexTest;
                    }
                }
                // End of the non-duplicate sub array, see if this array is the longest
                else
                {
                    startIndexTest = i;
                    endIndexTest = i;
                    hash.Clear();
                }
            }
            int resultArrayLength = endIndexFound - startIndexFound + 1;
            int[] resultArray = new int[resultArrayLength];

            Array.Copy(array, startIndexFound, resultArray, 0, resultArrayLength);

            return resultArray;
        }
    }
}

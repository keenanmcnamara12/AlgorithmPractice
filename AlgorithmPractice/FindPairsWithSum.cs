using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class FindPairsWithSum
    {
        /// <summary>
        /// Looks through a specified array for two elements that add to the specified sum
        /// </summary>
        /// <param name="array">array to look through</param>
        /// <param name="sumToFind">the sum to search for in the specified array</param>
        /// <param name="resultArray">array of length two containing the indices that add to the sum </param>
        /// <returns>true if the sum was found, false otherwise</returns>
        public static bool Find(int[] array, int sumToFind, out int[] resultArray)
        {
            resultArray = new int[2];
            int[] arrayCopy = new int[array.Length];

            // O(n) Make a copy so we don't modify the input and so we can report the original index
            Array.Copy(array, arrayCopy, array.Length);

            // O(n log n)
            Array.Sort(arrayCopy, (x, y) => x.CompareTo(y));

            int i = 0;
            int j = arrayCopy.Length - 1;
            bool found = false;
            int foundIdx1 = -1;
            int foundIdx2 = -1;

            // O(n)
            while (!found && i < j)
            {
                int sum = arrayCopy[i] + arrayCopy[j];
                if (sum == sumToFind)
                {
                    found = true;
                    foundIdx1 = i;
                    foundIdx2 = j;
                }
                else if (sum > sumToFind)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            // O(n) - Find the appropriate index
            // Sure there are ways to track the original index without searching again, but we
            // already have an O(n) hit on the search through the sorted list, so another O(n) 
            // operation doens't make much of a difference and allows for keeping types and clever
            // library use to a min.
            if (foundIdx1 != -1 && foundIdx2 != -1)
            {
                resultArray[0] = resultArray[1] = -1;
                for (int k = 0; k < array.Length; k++)
                {
                    if (array[k] == arrayCopy[foundIdx1])
                    {
                        resultArray[0] = k;
                        if (resultArray[0] != -1 && resultArray[1] != -1)
                            break;
                    }
                    else if (array[k] == arrayCopy[foundIdx2])
                    {
                        resultArray[1] = k;
                        if (resultArray[0] != -1 && resultArray[1] != -1)
                            break;
                    }
                }

                // Let's be nice and give back the indices in order
                if (resultArray[0] > resultArray[1])
                {
                    int temp = resultArray[0];
                    resultArray[0] = resultArray[1];
                    resultArray[1] = temp;
                }
            }

            return found;
        }
    }
}

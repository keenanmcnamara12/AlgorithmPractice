using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice
{
    public class Sort
    {
        /// <summary>
        /// Given a binary array, sorts the array in linear time with constant size
        /// </summary>
        /// <param name="array">Binary array to sort</param>
        /// <returns>the original array but sorted</returns>
        public static int[] SortBinaryArray(int[] array)
        {
            int lowIndex = 0;
            int highIndex = array.Length - 1;

            bool done = false;

            // Algorithm - work to fill in the outside in by finding an innapropriate value on each side
            // of the array then swapping them. Only traverses the array once for an O(N) perf.
            while (!done)
            {
                // Find a low index that needs to be moved (a one on the low side)
                while (array[lowIndex] != 1)
                    lowIndex++;

                // Find a high index that needs to be moved (a zero on the high side)
                while (array[highIndex] != 0)
                    highIndex--;

                if (lowIndex >= highIndex)
                {
                    done = true;
                    break;
                }

                // Swap
                int temp = array[lowIndex];
                array[lowIndex] = array[highIndex];
                array[highIndex] = temp;
            }

            return array;
        }
    }
}

using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class FindDuplicateElement
    {
        /// <summary>
        /// Finds a duplicate element in an array in linear time.
        /// </summary>
        /// <param name="array">Array to look for a duplicate</param>
        /// <param name="duplicateElement">Duplicate element that is found when the function returns true. If returns false, this param will be -1.</param>
        /// <returns>Returns true when a duplicate element is found. False otherwise.</returns>
        public static bool Find(int[] array, out int duplicateElement)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (hash.Contains(array[i]))
                {
                    duplicateElement = array[i];
                    return true;
                }

                hash.Add(array[i]);
            }
            duplicateElement = -1;
            return false;
        }
    }
}

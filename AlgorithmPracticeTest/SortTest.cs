using AlgorithmPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmPracticeTests
{
    /// <summary>
    /// Test class for Sort.cs
    /// </summary>
    [TestClass]
    public class SortTest
    {
        private readonly int[] TestArray1 = new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 1, 0 };
        private readonly int[] TestArray1Sorted = new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 };

        [TestMethod]
        public void SortBinaryArray_TestArray1_ReturnsTrue()
        {
            int[] result = Sort.SortBinaryArray(TestArray1);
            Assert.IsTrue(Sort.SortBinaryArray(TestArray1).SequenceEqual(TestArray1Sorted));
            Assert.IsTrue(true);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice;
using System.Linq;

namespace AlgorithmPracticeTests
{
    [TestClass]
    public class FindMaxLengthSubArrayWithSumTest
    {
        private readonly int[] TestArray1 = new int[] { 1, 2, 3, 4, 5, 6 };
        private readonly int[] TestArray2 = new int[] { 1, 2, 5, 6 };
        private readonly int[] TestArray3 = new int[] { 20, 5, 10, 5 };

        [TestMethod]
        public void Find_TestArray1_FindsSum()
        {
            Assert.IsTrue(FindMaxLengthSubArrayWithSum.Find(TestArray1, 1, out int[] resultArray));
            Assert.IsTrue(FindMaxLengthSubArrayWithSum.Find(TestArray1, 21, out int[] resultArray2));
            Assert.IsTrue(FindMaxLengthSubArrayWithSum.Find(TestArray1, 6, out int[] resultArray3));
        }

        [TestMethod]
        public void Find_TestArray1_FindsArray()
        {
            // Start index
            FindMaxLengthSubArrayWithSum.Find(TestArray1, 1, out int[] resultArray);
            Assert.IsTrue(resultArray.SequenceEqual(new int[] { 1 }));

            // Full array sum
            FindMaxLengthSubArrayWithSum.Find(TestArray1, 21, out int[] resultArray2);
            Assert.IsTrue(resultArray2.SequenceEqual(TestArray1));

            // Sub array sum
            FindMaxLengthSubArrayWithSum.Find(TestArray1, 6, out int[] resultArray3);
            Assert.IsTrue(resultArray3.SequenceEqual( new int[] { 1, 2, 3 }));

            // End index
            FindMaxLengthSubArrayWithSum.Find(TestArray2, 6, out int[] resultArray4);
            Assert.IsTrue(resultArray4.SequenceEqual(new int[] { 6 }));

            // Max length (not just the first sum found)
            FindMaxLengthSubArrayWithSum.Find(TestArray3, 20, out int[] resultArray5);
            Assert.IsTrue(resultArray5.SequenceEqual(new int[] { 5, 10, 5 }));
        }

    }
}

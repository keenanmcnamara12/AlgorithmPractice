using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice
{
    /// <summary>
    /// Test class for FindParisWithSum.cs
    /// </summary>
    [TestClass]
    public class FindPairsWithSumTests
    {
        private readonly int[] TestArray1 = new int[] { 1, 5, 9, 6, 3, 2, 10, 1 };
        private readonly int[] TestArray2 = new int[] { 3, 5, 9, 6, 1, 10, 2 };
        private readonly int[] TestArray3 = new int[] { 1, 5, 9, 6, 3, 3, 10, 1 };
        private readonly int[] TestArray4 = new int[] { };

        [TestMethod]
        public void Find_TestArray1_ReturnsTrue()
        {
            Assert.IsTrue(FindPairsWithSum.Find(TestArray1, 5, out int[] resultArray));
        }

        [TestMethod]
        public void Find_TestArray2_ReturnsTrue()
        {
            Assert.IsTrue(FindPairsWithSum.Find(TestArray2, 5, out int[] resultArray));
        }

        [TestMethod]
        public void Find_TestArray3_ReturnsFalse()
        {
            Assert.IsFalse(FindPairsWithSum.Find(TestArray3, 5, out int[] resultArray));
        }

        [TestMethod]
        public void Find_TestArray4_ReturnsFalse()
        {
            Assert.IsFalse(FindPairsWithSum.Find(TestArray4, 5, out int[] resultArray));
        }

        [TestMethod]
        public void Find_TestArray1_CorrectIndices()
        {
            Assert.IsTrue(FindPairsWithSum.Find(TestArray1, 5, out int[] resultArray));
            Assert.IsTrue(resultArray[0] == 4 && resultArray[1] == 5);
        }

        [TestMethod]
        public void Find_TestArray2_CorrectIndices()
        {
            Assert.IsTrue(FindPairsWithSum.Find(TestArray2, 5, out int[] resultArray));
            Assert.IsTrue(resultArray[0] == 0 && resultArray[1] == 6);
        }
    }
}

using AlgorithmPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmPracticeTests
{
    [TestClass]
    public class FindLargestSubArrayConsecutiveIntTest
    {
        private readonly int[] TestArray1 = new int[] { 1, 2, 3, 4, 5, 6 };
        private readonly int[] TestArray2 = new int[] { 1, 2, 3, 4, 4 };
        private readonly int[] TestArray2_Sub = new int[] { 1, 2, 3, 4 };
        private readonly int[] TestArray3 = new int[] { 1, 2, 3, 1, 2, 3, 4, 5 };
        private readonly int[] TestArray3_Sub = new int[] { 1, 2, 3, 4, 5 };

        [TestMethod]
        public void Find_TestArray1_FindsLargestSub()
        {
            Assert.IsTrue(FindLargestSubArrayConsecutiveInt.Find(TestArray1).SequenceEqual(TestArray1));
        }

        [TestMethod]
        public void Find_TestArray2_FindsLargestSub()
        {
            Assert.IsTrue(FindLargestSubArrayConsecutiveInt.Find(TestArray2).SequenceEqual(TestArray2_Sub));
        }

        [TestMethod]
        public void Find_TestArray3_FindsLargestSub()
        {
            Assert.IsTrue(FindLargestSubArrayConsecutiveInt.Find(TestArray3).SequenceEqual(TestArray3_Sub));
        }

    }
}

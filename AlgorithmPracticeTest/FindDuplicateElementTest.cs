using AlgorithmPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTests
{
    [TestClass]
    public class FindDuplicateElementTest
    {
        private readonly int[] TestArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4 };

        [TestMethod]
        public void Find_TestArray1_ReturnsTrue()
        {
            Assert.IsTrue(FindDuplicateElement.Find(TestArray1, out int duplicateNum));
        }

        [TestMethod]
        public void Find_TestArray1_FindsDuplicate()
        {
            FindDuplicateElement.Find(TestArray1, out int duplicateNum);
            Assert.IsTrue(duplicateNum == 4);
        }
    }
}

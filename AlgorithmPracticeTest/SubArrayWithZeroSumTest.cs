using AlgorithmPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPracticeTests
{
    /// <summary>
    /// Test class for SubArrayWithZeroSum.cs
    /// </summary>
    [TestClass]
    public class SubArrayWithZeroSumTest
    {
        private readonly int[] TestArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly int[] TestArray2 = new int[] { 0 };
        private readonly int[] TestArray3 = new int[] { 1, 2, 3, -6 };
        private readonly int[] TestArray4 = new int[] { 1, 2, 3, -5, -1 };
        private readonly int[] TestArray5 = new int[] { 1, 2, -5, -1, 3, 99 };
        private readonly int[] TestArray6 = new int[] { 0, 1, 3, -4, 5, -5, 1 };
        private readonly int[] TestArray7 = new int[] { 1, 2, 3, 0 };

        [TestMethod]
        public void Check_TestArray1_ReturnsFalse()
        {
            Assert.IsFalse(SubArrayWithZeroSum.Check(TestArray1));
        }

        [TestMethod]
        public void Check_TestArray2_ReturnsTrue()
        {
            Assert.IsTrue(SubArrayWithZeroSum.Check(TestArray2));
        }

        [TestMethod]
        public void Check_TestArray3_ReturnsTrue()
        {
            Assert.IsTrue(SubArrayWithZeroSum.Check(TestArray3));
        }

        [TestMethod]
        public void Check_TestArray4_ReturnsTrue()
        {
            Assert.IsTrue(SubArrayWithZeroSum.Check(TestArray4));
        }

        [TestMethod]
        public void Check_TestArray5_ReturnsTrue()
        {
            Assert.IsTrue(SubArrayWithZeroSum.Check(TestArray5));
        }

        [TestMethod]
        public void Find_TestArray6_ReturnsTrue()
        {
            List<int[]> list = SubArrayWithZeroSum.Find(TestArray6);
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 0, 1, 3, -4, 5, -5 })));
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 0, 1, 3, -4, 5, -5 })));
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 1, 3, -4, 5, -5 })));
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 3, -4, 5, -5, 1 })));
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 0, 1, 3, -4 })));
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 1, 3, -4 })));
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 5, -5 })));
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 0 })));
        }

        [TestMethod]
        public void Find_TestArray7_ReturnsTrue()
        {
            // Specifically looking for an array that just has a zero at any index
            List<int[]> list = SubArrayWithZeroSum.Find(TestArray7);
            Assert.IsTrue(list.Any(x => x.SequenceEqual(new int[] { 0 })));
        }
    }
}

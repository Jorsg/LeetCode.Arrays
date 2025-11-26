using LeetCode.HashTable;
namespace TestHashTable
{
    [TestClass]
    public sealed class ContainsDuplicate
    {
        [TestMethod]
        public void Test_ContainsNearbyDuplicateExcer_true()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 3, 1 };
            int k = 3;
            bool expected = true;
            //Act
            bool actual = LeetCode.HashTable.ContainsDuplicate.ContainsNearbyDuplicateExcer(nums, k);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]    
        public void Test_ContainsNearbyDuplicateExcer_false()
        {
            //Arrange
            int[] nums = new int[] { 1, 0, 2, 3 };
            int k = 1;
            bool expected = false;
            //Act
            bool actual = LeetCode.HashTable.ContainsDuplicate.ContainsNearbyDuplicateExcer(nums, k);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_ContainsDuplicateExcer_true()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 3, 1 };
            bool expected = true;
            //Act
            bool actual = LeetCode.HashTable.ContainsDuplicate.ContainsDuplicateExcer(nums);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsDuplicateExcer_false()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 3, 4 };
            bool expected = false;
            //Act
            bool actual = LeetCode.HashTable.ContainsDuplicate.ContainsDuplicateExcer(nums);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_ContainsNearbyDuplicateII_true()
        {
            //Arrange
            int[] nums = new int[] { 1, 0, 1, 1 };
            int k = 1;
            bool expected = true;
            //Act
            bool actual = LeetCode.HashTable.ContainsDuplicate.ContainsNearbyDuplicate(nums, k);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_ContainsNearbyDuplicateII_false()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool expected = false;
            //Act
            bool actual = LeetCode.HashTable.ContainsDuplicate.ContainsNearbyDuplicate(nums, k);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

    
}

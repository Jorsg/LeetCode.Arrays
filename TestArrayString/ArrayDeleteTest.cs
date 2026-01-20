using LeetCode.Arrays;

namespace TestArrayString;

[TestClass]
public class ArrayDeleteTest
{
    [TestMethod]
    public void Test_DeleteDuplicate()
    {        
        int[] nums = new int[] { 1, 1, 2 };
        int expectedLength = 2;
        int actualLength = ArrayDelete.RemoveDuplicates(nums);
        Assert.AreEqual(expectedLength, actualLength);
    }

    [TestMethod]
    public void Test_DeleteDuplicate_NoDuplicates()
    {
        int[] nums = new int[] { 1, 2, 3 };
        int expectedLength = 3;
        int actualLength = ArrayDelete.RemoveDuplicates(nums);
        Assert.AreEqual(expectedLength, actualLength);
    }
}

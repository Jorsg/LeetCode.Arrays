using LeetCode.Arrays;

namespace TestArrayString;

[TestClass]
public class RemoveDuplicateTest
{
    [TestMethod]
    public void Test_RemoveDuplicate()
    {
        int[] nums = { 1, 1, 2,};
        int expectative = 2;

        var result = RemoveDuplicate.RemoveDuplicateArray(nums);
        Assert.AreEqual(expectative, result);
    }

    //Test Remove Duplicate
    [TestMethod]
    public void Test_RemoveDuplicate_Null()
    {
        int[] nums = { };
        int expectative = 0;
        var result = RemoveDuplicate.RemoveDuplicateArray(nums);
        Assert.AreEqual(expectative, result);
    }
}

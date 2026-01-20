namespace TestArrayString;

[TestClass]
public class RotateArrayTest
{
    [TestMethod]
    public void Test_RotateArray()
    {
        var array = new RotateArrayTest();
        int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        LeetCode.ArrayString.RotateArray.Rotate(nums, k);
        Assert.AreNotEqual(nums.Length, k);
    }

    [TestMethod]
    public void Test_RotateArray_Empty()
    {
        var array = new RotateArrayTest();
        int[] nums = new int[] { };
        int k = 3;
        LeetCode.ArrayString.RotateArray.Rotate(nums, k);
        Assert.IsEmpty("");
    }

    [TestMethod]
    public void Test_RotateArrayRight() {
        var array = new RotateArrayTest();
        int[] nums = new int[] { 1, 2, 3, 4, 5 };
        int k = 2;
        LeetCode.ArrayString.RotateArray.RotateArrytoRigth(nums, k);
        Assert.AreNotEqual(nums.Length, k);
    }

    [TestMethod]
    public void Test_RotateArrayRight_Empty()
    {
        var array = new RotateArrayTest();
        int[] nums = new int[] { };
        int k = 2;
        LeetCode.ArrayString.RotateArray.RotateArrytoRigth(nums, k);
        Assert.IsEmpty("");
    }
}

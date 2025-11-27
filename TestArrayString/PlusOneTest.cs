namespace TestArrayString;

[TestClass]
public class PlusOneTest
{
    [TestMethod]
    public void Test_PlusOne()
    {
        // Arrange
        int[] nums = new int[] { 1, 2, 3 };
        int[] expected = new int[] { 1, 2, 4 };
        // Act
        int[] result = LeetCode.Arrays.PlusOneExercise.PlusOne(nums);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Test_PlusOne_CarryOver()
    {
        // Arrange
        int[] nums = new int[] { 9, 9, 9 };
        int[] expected = new int[] { 1, 0, 0, 0 };
        // Act
        int[] result = LeetCode.Arrays.PlusOneExercise.PlusOne(nums);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}

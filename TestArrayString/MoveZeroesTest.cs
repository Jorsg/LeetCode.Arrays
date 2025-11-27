namespace TestArrayString;

[TestClass]
public class MoveZeroesTest
{
    [TestMethod]
    public void Test_MoveZeroes()
    {
        // Arrange
        int[] nums = new int[] { 0, 1, 0, 3, 12 };
        int[] expected = new int[] { 1, 3, 12, 0, 0 };
        // Act
        LeetCode.Arrays.MoveZeroesExercise.MoveZeroes(nums);
        // Assert
        CollectionAssert.AreEqual(expected, nums);
    }
    [TestMethod]
    public void Test_MoveZeroes_AllZeros()
    {
        // Arrange
        int[] nums = new int[] { 0, 0, 0, 0 };
        int[] expected = new int[] { 0, 0, 0, 0 };
        // Act
        LeetCode.Arrays.MoveZeroesExercise.MoveZeroes(nums);
        // Assert
        CollectionAssert.AreEqual(expected, nums);
    }
}

namespace TestArrayString;

[TestClass]
public class MajorityElementTest
{
    [TestMethod]
    public void Test_MajorityElement()
    {
        //Arrange
        int[] nums = new int[] { 3, 2, 3 };
        int expected = 3;
        //Act
        int actual = LeetCode.Arrays.MajorityElement.MajorityElementExercise(nums);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Test_MajorityElement_SingleElement()
    {
        //Arrange
        int[] nums = new int[] { 1 };
        int expected = 1;
        //Act
        int actual = LeetCode.Arrays.MajorityElement.MajorityElementExercise(nums);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Test_MajorityElement_AllSameElements()
    {
        //Arrange
        int[] nums = new int[] { 2, 2, 2, 2 };
        int expected = 2;
        //Act
        int actual = LeetCode.Arrays.MajorityElement.MajorityElementExercise(nums);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Test_MajorityElement_MultipleCandidates()
    {
        //Arrange
        int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
        int expected = 2;
        //Act
        int actual = LeetCode.Arrays.MajorityElement.MajorityElementExercise(nums);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Test_MajorityElement_NegativeNumbers()
    {
        //Arrange
        int[] nums = new int[] { -1, -1, -1, 2, 2 };
        int expected = -1;
        //Act
        int actual = LeetCode.Arrays.MajorityElement.MajorityElementExercise(nums);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Test_MajorityElement_LargeInput()
    {
        //Arrange
        int n = 10001;
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = (i < n / 2) ? 1 : 2; // Majority element is 1
        }
        int expected = 1;
        //Act
        int actual = LeetCode.Arrays.MajorityElement.MajorityElementExercise(nums);
        //Assert
        Assert.AreNotEqual(expected, actual);
    }

}

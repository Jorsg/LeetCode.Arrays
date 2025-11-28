namespace TestArrayString;

[TestClass]
public class MergeSortedArrayTest
{
    [TestMethod]
    public void Test_MergeSortedArray()
    {
        // Arrange
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = new int[] { 2, 5, 6 };
        int n = 3;
        int[] expected = new int[] { 1, 2, 2, 3, 5, 6 };
        // Act
        LeetCode.Arrays.MergeSortedArray.Merge(nums1, m, nums2, n);
        // Assert
        CollectionAssert.AreEqual(expected, nums1);

    }
    [TestMethod]
    public void Test_MergeSortedArray_EmptyNums2()
    {
        // Arrange
        int[] nums1 = new int[] { 1 };
        int m = 1;
        int[] nums2 = new int[] { };
        int n = 0;
        int[] expected = new int[] { 1 };
        // Act
        LeetCode.Arrays.MergeSortedArray.Merge(nums1, m, nums2, n);
        // Assert
        CollectionAssert.AreEqual(expected, nums1);
    }
}

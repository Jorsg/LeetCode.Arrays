namespace TestArrayString;

[TestClass]
public class ThreeSumTest
{
    [TestMethod]
    public void Test_ThreeSum()
    {
        int[] nums = { -1, 0, 1, 2, -1, -4 };

        List<IList<int>> expectative = new List<IList<int>>
        {
            new List<int> { -1, -1, 2 },
            new List<int> { -1, 0, 1 }
        };

        var result = LeetCode.ArrayString.ThreeSumExercise.ThreeSum(nums);
        foreach (var item in expectative)
        {
            Assert.IsTrue(result.Any(r=> r.SequenceEqual(item)),
                $"Missing triplet: {string.Join(" , ", item) }");
        }
        Assert.AreEqual(expectative.Count, result.Count);
    }

    [TestMethod]
    public void Test_ThreeSum_Empty()
    {
        int[] nums = { };
        List<IList<int>> expectative = new List<IList<int>>();
        var result = LeetCode.ArrayString.ThreeSumExercise.ThreeSum(nums);
        Assert.AreEqual(expectative.Count, result.Count);
    }
}

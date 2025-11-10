using LeetCode.ArrayString;
namespace TestArrayString;

[TestClass]
public class TwoSumIITest
{
    [TestMethod]
    public void TestMethod_TwoSumII_1()
    {
        var array = new[] { 2, 7, 11, 15 };
        var target = 9;
        var expected = new[] { 1, 2 };
        var twoSum = new TwoSummII();
        var result = twoSum.TwoSum(array, target);
        CollectionAssert.AreEqual(expected, result);

    }

    [TestMethod]
    public void TestMethod_TwoSumII_2()
    {
        var array = new[] { 2, 3, 4 };
        var target = 6;
        var expected = new[] { 1, 3 };
        var twoSum = new TwoSummII();
        var result = twoSum.TwoSum(array, target);
        CollectionAssert.AreEqual(expected, result);

    }
}

[TestClass]
public class TwoSum_1Test
{
    [TestMethod]
    public void TestMethod_TwoSum_V1()
    {
        var array = new[] { 2, 7, 11, 15 };
        var target = 9;
        var expected = new[] { 0, 1 };
        var twoSum = new TwoSum_1();
        var result = twoSum.TwoSum(array, target);
        CollectionAssert.AreEqual(expected, result);
    }
    [TestMethod]
    public void TestMethod_TwoSum_V2()
    {
        var array = new[] { 3, 2, 4 };
        var target = 6;
        var expected = new[] { 1, 2 };
        var twoSum = new TwoSum_1();
        var result = twoSum.TwoSum(array, target);
        CollectionAssert.AreEqual(expected, result);
    }
}

namespace TestArrayString;

[TestClass]
public class LongestCommonPrefixTest
{
    [TestMethod]
    public void Test_LongestCommonPrefix()
    {
        // Arrange
        var lcp = new LeetCode.ArrayString.LongestCommonPrefix();
        // Act & Assert
        Assert.AreEqual("fl", lcp.LongestCommonPrefix_Excercise(new string[] { "flower", "flow", "flight" }));
        Assert.AreEqual("", lcp.LongestCommonPrefix_Excercise(new string[] { "dog", "racecar", "car" }));
        Assert.AreEqual("a", lcp.LongestCommonPrefix_Excercise(new string[] { "a" }));
        Assert.AreEqual("", lcp.LongestCommonPrefix_Excercise(new string[] { "" }));
       
        // Act & Assert for V2
        Assert.AreEqual("fl", lcp.LongestCommonPrefix_V2(new string[] { "flower", "flow", "flight" }));
        Assert.AreEqual("", lcp.LongestCommonPrefix_V2(new string[] { "dog", "racecar", "car" }));
        Assert.AreEqual("a", lcp.LongestCommonPrefix_V2(new string[] { "a" }));
        Assert.AreEqual("", lcp.LongestCommonPrefix_V2(new string[] { "" }));
    }
}

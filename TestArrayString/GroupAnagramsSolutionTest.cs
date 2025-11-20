using LeetCode.HashTable;
namespace TestArrayString;

[TestClass]
public sealed class GroupAnagramsSolutionTest
{
    [TestMethod]
    public void GroupAnagrams_Example1_ReturnsGroupedAnagrams()
    {
        // Arrange
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagrams(strs);

        // Assert
        Assert.AreEqual(3, result.Count);

        // Verify each group contains the expected anagrams
        bool hasEatGroup = result.Any(group => group.Count == 3 &&
            group.Contains("eat") && group.Contains("tea") && group.Contains("ate"));
        bool hasTanGroup = result.Any(group => group.Count == 2 &&
            group.Contains("tan") && group.Contains("nat"));
        bool hasBatGroup = result.Any(group => group.Count == 1 &&
            group.Contains("bat"));

        Assert.IsTrue(hasEatGroup);
        Assert.IsTrue(hasTanGroup);
        Assert.IsTrue(hasBatGroup);
    }

    [TestMethod]
    public void GroupAnagrams_Example2_EmptyString_ReturnsSingleGroup()
    {
        // Arrange
        string[] strs = { "" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagrams(strs);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(1, result[0].Count);
        Assert.AreEqual("", result[0][0]);
    }

    [TestMethod]
    public void GroupAnagrams_Example3_SingleCharacter_ReturnsSingleGroup()
    {
        // Arrange
        string[] strs = { "a" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagrams(strs);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(1, result[0].Count);
        Assert.AreEqual("a", result[0][0]);
    }

    [TestMethod]
    public void GroupAnagrams_NullArray_ReturnsEmptyList()
    {
        // Arrange
        string[] strs = null;

        // Act
        var result = GroupAnagramsSolution.GroupAnagrams(strs);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void GroupAnagrams_EmptyArray_ReturnsEmptyList()
    {
        // Arrange
        string[] strs = Array.Empty<string>();

        // Act
        var result = GroupAnagramsSolution.GroupAnagrams(strs);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void GroupAnagrams_NoAnagrams_ReturnsIndividualGroups()
    {
        // Arrange
        string[] strs = { "abc", "def", "ghi" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagrams(strs);

        // Assert
        Assert.AreEqual(3, result.Count);
        foreach (var group in result)
        {
            Assert.AreEqual(1, group.Count);
        }
    }

    [TestMethod]
    public void GroupAnagrams_AllSameAnagrams_ReturnsSingleGroup()
    {
        // Arrange
        string[] strs = { "abc", "bca", "cab", "acb" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagrams(strs);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(4, result[0].Count);
    }

    [TestMethod]
    public void GroupAnagramsLeetCodeBestSolution_Example1_ReturnsGroupedAnagrams()
    {
        // Arrange
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagramsLeetCodeBetsSolution(strs);

        // Assert
        Assert.AreEqual(3, result.Count);

        // Verify each group contains the expected anagrams
        bool hasEatGroup = result.Any(group => group.Count == 3 &&
            group.Contains("eat") && group.Contains("tea") && group.Contains("ate"));
        bool hasTanGroup = result.Any(group => group.Count == 2 &&
            group.Contains("tan") && group.Contains("nat"));
        bool hasBatGroup = result.Any(group => group.Count == 1 &&
            group.Contains("bat"));

        Assert.IsTrue(hasEatGroup);
        Assert.IsTrue(hasTanGroup);
        Assert.IsTrue(hasBatGroup);
    }

    [TestMethod]
    public void GroupAnagramsLeetCodeBestSolution_Example2_EmptyString_ReturnsSingleGroup()
    {
        // Arrange
        string[] strs = { "" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagramsLeetCodeBetsSolution(strs);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(1, result[0].Count);
        Assert.AreEqual("", result[0][0]);
    }

    [TestMethod]
    public void GroupAnagramsLeetCodeBestSolution_Example3_SingleCharacter_ReturnsSingleGroup()
    {
        // Arrange
        string[] strs = { "a" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagramsLeetCodeBetsSolution(strs);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(1, result[0].Count);
        Assert.AreEqual("a", result[0][0]);
    }

    [TestMethod]
    public void GroupAnagramsLeetCodeBestSolution_NoAnagrams_ReturnsIndividualGroups()
    {
        // Arrange
        string[] strs = { "abc", "def", "ghi" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagramsLeetCodeBetsSolution(strs);

        // Assert
        Assert.AreEqual(3, result.Count);
        foreach (var group in result)
        {
            Assert.AreEqual(1, group.Count);
        }
    }

    [TestMethod]
    public void GroupAnagramsLeetCodeBestSolution_AllSameAnagrams_ReturnsSingleGroup()
    {
        // Arrange
        string[] strs = { "abc", "bca", "cab", "acb" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagramsLeetCodeBetsSolution(strs);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(4, result[0].Count);
    }

    [TestMethod]
    public void GroupAnagramsLeetCodeBestSolution_MixedCaseAndLength_ReturnsCorrectGroups()
    {
        // Arrange
        string[] strs = { "listen", "silent", "hello", "world", "enlist" };

        // Act
        var result = GroupAnagramsSolution.GroupAnagramsLeetCodeBetsSolution(strs);

        // Assert
        Assert.AreEqual(3, result.Count);

        bool hasListenGroup = result.Any(group => group.Count == 3 &&
            group.Contains("listen") && group.Contains("silent") && group.Contains("enlist"));
        Assert.IsTrue(hasListenGroup);
    }

    [TestMethod]
    public void BothMethods_SameInput_ProduceSameResults()
    {
        // Arrange
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        var result1 = GroupAnagramsSolution.GroupAnagrams(strs);
        var result2 = GroupAnagramsSolution.GroupAnagramsLeetCodeBetsSolution(strs);

        // Assert
        Assert.AreEqual(result1.Count, result2.Count);
    }
}


using LeetCode.ArrayString;

namespace TestArrayString;

[TestClass]
public class ReverseStringCodeTest
{
    [TestMethod]
    public void Test_ReverseString()
    {
        char[] s = { 'h', 'e', 'l', 'l', 'o' };
        char[] expected = { 'o', 'l', 'l', 'e', 'h' };

        //Act
        ReverseStringLeetCode.ReverseString(s);
        //Assert
        CollectionAssert.AreEqual(expected, s);
    }

    [TestMethod]
    [DataRow(new char[] { 'A', 'B', 'C' }, new char[] { 'C', 'B', 'A' })]
    [DataRow(new char[] { 'X' }, new char[] { 'X' })]
    [DataRow(new char[] { }, new char[] { })]
    public void ReverseString_MultipleCases_ShouldPass(char[] input, char[] expected)
    {
        // Act
        ReverseStringLeetCode.ReverseString(input);

        // Assert
        CollectionAssert.AreEqual(expected, input);
    }

    [TestMethod]
    public void Test_ReverseWords()
    {
        string s = "Hello World";
        string expected = "World Hello";
        //Act
        string actual = ReverseStringLeetCode.ReverseWords(s);
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test_ReverseWordsIII()
    {
        void TestCase(string input, string expected)
        {
            //Act
            string actual = ReverseStringLeetCode.ReverseWordsIII(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

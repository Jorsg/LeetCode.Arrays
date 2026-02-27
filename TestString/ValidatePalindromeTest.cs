namespace TestString;

[TestClass]
public class ValidatePalindromeTest
{
    [TestMethod]
    public void Test_IsPalidrome()
    {
        string s = "A man, a plan, a canal: Panama";
        bool expected = true;

        var result = LeetCode.String.ValidatePalindrome.IsPalindrome(s);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Not_IsPalidrome()
    {
        string s = "race a car";
        bool expected = false;
        var result = LeetCode.String.ValidatePalindrome.IsPalindrome(s);
        Assert.AreEqual(expected, result);
    }
}

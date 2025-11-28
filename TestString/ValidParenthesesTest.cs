using LeetCode.String;
namespace TestString
{
    /// <summary>
    /// Provides unit tests for validating the behavior of the ValidParenthesesLeetCode class.
    /// </summary>
    /// <remarks>This test class uses MSTest attributes to define and execute test methods for the
    /// ValidParenthesesLeetCode implementation. Each test method verifies specific scenarios to ensure correct
    /// functionality.</remarks>
    [TestClass]
    public sealed class ValidParenthesesTest
    {
        [TestMethod]
        public void IsValid_Test()
        {
            // Arrange
            string s = "()";
            LeetCode.String.ValidParenthesesLeetCode validParentheses = new LeetCode.String.ValidParenthesesLeetCode();
            // Act
            bool result = validParentheses.IsValid(s);
            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IsValid_Test2()
        {
            // Arrange
            string s = "([)]";
            LeetCode.String.ValidParenthesesLeetCode validParentheses = new LeetCode.String.ValidParenthesesLeetCode();
            // Act
            bool result = validParentheses.IsValid(s);
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_Test3()
        {
            // Arrange
            string s = "{[]}";
            LeetCode.String.ValidParenthesesLeetCode validParentheses = new LeetCode.String.ValidParenthesesLeetCode();
            // Act
            bool result = validParentheses.IsValid(s);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsValid_Test4() {
         // Arrange
            string s = "((()))";
            LeetCode.String.ValidParenthesesLeetCode validParentheses = new LeetCode.String.ValidParenthesesLeetCode();
            // Act
            bool result = validParentheses.IsValid(s);
            // Assert
            Assert.IsTrue(result);
        }
    }
}

using LeetCode.String;
namespace TestString;

[TestClass]
public class RomanToIntTest
{
    [TestMethod]
    public void Test_RomanToInt()
    {
        // Arrange
        string roman = "MCMXCIV";
        int expected = 1994;
        // Act
        int result = RomanToIntExercise.RomanToInt(roman);
        // Assert
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Test_RomanToInt_SingleNumeral()
    {
        // Arrange
        string roman = "V";
        int expected = 5;
        // Act
        int result = RomanToIntExercise.RomanToInt(roman);
        // Assert
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Test_RomanToInt_SubtractiveNotation()
    {
        // Arrange
        string roman = "IV";
        int expected = 4;
        // Act
        int result = RomanToIntExercise.RomanToInt(roman);
        // Assert
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Test_RomanToInt_LargeNumber()
    {
        // Arrange
        string roman = "MMXXIV";
        int expected = 2024;
        // Act
        int result = RomanToIntExercise.RomanToInt(roman);
        // Assert
        Assert.AreEqual(expected, result);
    }
}

namespace TestArrayString;

[TestClass]
public class BestTimeBuySellStock
{
    [TestMethod]
    public void Test_BestTimeBuySellStock()
    {
        //Arrange
        int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
        int expected = 5;
        //Act
        int actual = LeetCode.Arrays.BestTimeBuySellStock.MaxProfit(prices);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Test_BestTimeBuySellStock_NoProfit()
    {
        //Arrange
        int[] prices = new int[] { 7, 6, 4, 3, 1 };
        int expected = 0;
        //Act
        int actual = LeetCode.Arrays.BestTimeBuySellStock.MaxProfit(prices);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Test_BestTimeBuySellStock_SingleDay()
    {
        //Arrange
        int[] prices = new int[] { 5 };
        int expected = 0;
        //Act
        int actual = LeetCode.Arrays.BestTimeBuySellStock.MaxProfit(prices);
        //Assert
        Assert.AreEqual(expected, actual);
    }
}

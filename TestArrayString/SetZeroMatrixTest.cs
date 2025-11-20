using LeetCode.ArrayString;
namespace TestArrayString;

[TestClass]
public class SetZeroMatrixTest
{
    /// <summary>
    /// crear una prueba unitaria para el metodo ZeroMatrix    
    /// </summary>
    [TestMethod]
    public void SetZeroMatrix_Test()
    {
        // Arrange
        int[,] matriz = new int[,]
        {
            {1, 2, 3},
            {4, 0, 6},
            {7, 8, 9}
        };
        // Act
        bool result = SetZeroMatrix.ZeroMatrix(matriz);
        // Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void SetZeroMatrix_NoZero_Test()
    {
        // Arrange
        int[,] matriz = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        // Act
        bool result = SetZeroMatrix.ZeroMatrix(matriz);
        // Assert
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void SetZeroMatrix_AllZero_Test()
    {
        // Arrange
        int[,] matriz = new int[,]
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };
        // Act
        bool result = SetZeroMatrix.ZeroMatrix(matriz);
        // Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void SetZeroMatrix_EmptyMatrix_Test()
    {
        // Arrange
        int[,] matriz = new int[0, 0];
        // Act
        bool result = SetZeroMatrix.ZeroMatrix(matriz);
        // Assert
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void SetZeroMatrix_SingleElementZero_Test()
    {
        // Arrange
        int[,] matriz = new int[,]
        {
            {0}
        };
        // Act
        bool result = SetZeroMatrix.ZeroMatrix(matriz);
        // Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void SetZeroMatrix_SingleElementNonZero_Test()
    {
        // Arrange
        int[,] matriz = new int[,]
        {
            {5}
        };
        // Act
        bool result = SetZeroMatrix.ZeroMatrix(matriz);
        // Assert
        Assert.IsFalse(result);
    }
}

using TestTaskLibrary.Calculators;
using TestTaskLibrary.Models;

namespace UnitTests.FiguresTest;

public class TriangleTest
{
    private readonly TriangleCalculator _triangleCalculator;
    
    public TriangleTest()
    {
        _triangleCalculator = new TriangleCalculator();
    }
    
    [Fact]
    public void SquareTestPositive()
    {
        var result = _triangleCalculator.CalculateSquare(new Triangle { A = 3, B = 4, C = 5 });

        Assert.Equal(6.0, result);
    } 
    
    [Fact]
    public void SquareTestNegative()
    {
        var result = _triangleCalculator.CalculateSquare(new Triangle { A = 0, B = 0, C = 0 });

        Assert.Equal(0, result);
    }
    
    [Fact]
    public void RightTrianglePositive()
    {
        var result = new Triangle { A = 10, B = 6, C = 8  }.RightTriangleCheck();

        Assert.True(result);
    } 
    
    [Fact]
    public void RightTriangleNegative()
    {
        var result = new Triangle { A = 3, B = 6, C = 2  }.RightTriangleCheck();

        Assert.False(result);
    }
}
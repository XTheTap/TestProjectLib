using TestTaskLibrary;
using TestTaskLibrary.Interfaces;
using TestTaskLibrary.Models;

namespace UnitTests.FiguresTest;

public class TriangleTest
{
    private readonly IFigureCalculator _triangleCalculator;
    
    public TriangleTest()
    {
        _triangleCalculator = new FigureCalculator();
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
        Assert.Throws<ArgumentException>(() => _triangleCalculator.CalculateSquare(new Triangle { A = 0, B = -5, C = 0 }));
    }
    
    [Fact]
    public void RightTrianglePositive()
    {
        var result = new Triangle { A = 10, B = 6, C = 8  }.StraightCheck();

        Assert.True(result);
    } 
    
    [Fact]
    public void RightTriangleNegative()
    {
        var result = new Triangle { A = 3, B = 6, C = 2  }.StraightCheck();

        Assert.False(result);
    }
}
using TestTaskLibrary;
using TestTaskLibrary.Interfaces;
using TestTaskLibrary.Models;

namespace UnitTests.FiguresTest;

public class CircleTest
{
    private readonly IFigureCalculator _circleCalculator;

    public CircleTest()
    {
        _circleCalculator = new FigureCalculator();
    }

    [Fact]
    public void SquareTestPositive()
    {
        var result = _circleCalculator.CalculateSquare(new Circle { Radius = 6.2 });

        Assert.Equal(120.76, Math.Round(result, 2));
    }
    
    [Fact]
    public void SquareTestNegative()
    {
        Assert.Throws<ArgumentException>(() => _circleCalculator.CalculateSquare(new Circle { Radius = 0 }));
    }
}
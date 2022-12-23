using TestTaskLibrary.Calculators;
using TestTaskLibrary.Models;

namespace UnitTests.FiguresTest;

public class CircleTest
{
    private readonly CircleCalculator _circleCalculator;

    public CircleTest()
    {
        _circleCalculator = new CircleCalculator();
    }

    [Fact]
    public void SquareTestPositive()
    {
        var result = _circleCalculator.CalculateSquare(new Circle { Radius = 6.2 });

        Assert.Equal(120.76, Math.Round(result, 2));
    }
}
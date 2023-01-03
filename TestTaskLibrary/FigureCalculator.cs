using TestTaskLibrary.Interfaces;

namespace TestTaskLibrary
{
    public class FigureCalculator : IFigureCalculator
    {
        public double CalculateSquare(IFigure figure)
        {
           return figure.CalculateSquare();
        }
    }
}
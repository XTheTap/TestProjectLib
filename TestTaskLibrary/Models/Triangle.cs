using System;
using TestTaskLibrary.Interfaces;

namespace TestTaskLibrary.Models
{
    public class Triangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public bool RightTriangleCheck()
        {
            var powA = Math.Pow(A, 2);
            var powB = Math.Pow(B, 2);
            var powC = Math.Pow(C, 2);

            var sigCosA = powB + powC - powA;
            var sigCosB = powC + powA - powB;
            var sigCosC = powA + powB - powC;

            return sigCosA == 0 || sigCosB == 0 || sigCosC == 0;
        }
        
        public double CalculateSquare(Triangle figure)
        {
            var p = (figure.A + figure.B + figure.C) / 2;
            return Math.Sqrt(p * (p - figure.A) * (p - figure.B) * (p - figure.C));
        }
    }
}
using System;
using TestTaskLibrary.Interfaces;

namespace TestTaskLibrary.Models
{
    public class Triangle : IFigure, IStraight
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get => _a;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be less or equal 0", nameof(A));
                }

                _a = value;
            }
        }

        public double B
        {
            get => _b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be less or equal 0", nameof(B));
                }

                _b = value;
            }
        }

        public double C
        {
            get => _c;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be less or equal 0", nameof(C));
                }

                _c = value;
            }
        }

        public bool StraightCheck()
        {
            var powA = Math.Pow(A, 2);
            var powB = Math.Pow(B, 2);
            var powC = Math.Pow(C, 2);

            var sigCosA = powB + powC - powA;
            var sigCosB = powC + powA - powB;
            var sigCosC = powA + powB - powC;

            return sigCosA == 0 || sigCosB == 0 || sigCosC == 0;
        }

        public double CalculateSquare()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
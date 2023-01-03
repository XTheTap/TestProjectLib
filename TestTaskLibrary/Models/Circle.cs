using System;
using TestTaskLibrary.Interfaces;

namespace TestTaskLibrary.Models
{
    public class Circle : IFigure
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be less or equal 0", nameof(Radius));
                }

                _radius = value;
            }
        }
        
        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

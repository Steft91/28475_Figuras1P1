using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class Rectangulo : IFigura
    {
        public double Base { get; }
        public double Altura { get; }

        public Rectangulo(double baseRect, double alturaRect)
        {
            if (baseRect <= 0) throw new ArgumentOutOfRangeException(nameof(baseRect));
            if (alturaRect <= 0) throw new ArgumentOutOfRangeException(nameof(alturaRect));
            Base = baseRect;
            Altura = alturaRect;
        }

        public double Area() => Base * Altura;
        public double Perimetro() => 2 * (Base + Altura);
    }
}
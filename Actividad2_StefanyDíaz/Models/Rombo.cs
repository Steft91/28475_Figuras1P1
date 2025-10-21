using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class Rombo : IFigura
    {
        public double DiagonalMayor { get; }
        public double DiagonalMenor { get; }

        public Rombo(double diagMayor, double diagMenor)
        {
            if (diagMayor <= 0) throw new ArgumentOutOfRangeException(nameof(diagMayor));
            if (diagMenor <= 0) throw new ArgumentOutOfRangeException(nameof(diagMenor));
            DiagonalMayor = diagMayor;
            DiagonalMenor = diagMenor;
        }

        public double Area() => (DiagonalMayor * DiagonalMenor) / 2;

        // Lado = sqrt((d1/2)^2 + (d2/2)^2)
        public double Perimetro()
        {
            double lado = Math.Sqrt(Math.Pow(DiagonalMayor / 2.0, 2) + Math.Pow(DiagonalMenor / 2.0, 2));
            return 4 * lado;
        }
    }
}
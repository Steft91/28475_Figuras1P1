using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class Trapecio : IFigura
    {
        public double BaseMayor { get; }
        public double BaseMenor { get; }
        public double Altura { get; }
        public double Lado { get; }

        public Trapecio(double baseMayor, double baseMenor, double altura, double lado)
        {
            if (baseMayor <= 0) throw new ArgumentOutOfRangeException(nameof(baseMayor));
            if (baseMenor <= 0) throw new ArgumentOutOfRangeException(nameof(baseMenor));
            if (altura <= 0) throw new ArgumentOutOfRangeException(nameof(altura));
            if (lado <= 0) throw new ArgumentOutOfRangeException(nameof(lado));

            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Lado = lado;
        }

        public double Area() => ((BaseMayor + BaseMenor) / 2.0) * Altura;
        public double Perimetro() => BaseMayor + BaseMenor + 2 * Lado;
    }
}
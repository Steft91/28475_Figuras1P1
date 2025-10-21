using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class Cuadrado : IFigura
    {
        public double Lado { get; }

        public Cuadrado(double lado)
        {
            if (lado <= 0) throw new ArgumentOutOfRangeException(nameof(lado));
            Lado = lado;
        }

        public double Area() => Lado * Lado;
        public double Perimetro() => 4 * Lado;
    }
}
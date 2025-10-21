using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class Triangulo : IFigura
    {
        public double Base { get; }
        public double Altura { get; }
        public double LadoA { get; }
        public double LadoB { get; }
        public double LadoC { get; }
        private readonly bool _sidesProvided;

        // Si solo se pasan base y altura, se asume triángulo equilátero para el perímetro (compatibilidad con tu UI).
        public Triangulo(double baseTri, double alturaTri, double ladoA = double.NaN, double ladoB = double.NaN, double ladoC = double.NaN)
        {
            if (baseTri <= 0) throw new ArgumentOutOfRangeException(nameof(baseTri));
            if (alturaTri <= 0) throw new ArgumentOutOfRangeException(nameof(alturaTri));

            Base = baseTri;
            Altura = alturaTri;

            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;

            _sidesProvided = !(double.IsNaN(ladoA) || double.IsNaN(ladoB) || double.IsNaN(ladoC));
        }

        public double Area() => (Base * Altura) / 2.0;

        public double Perimetro() => Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
    }
}
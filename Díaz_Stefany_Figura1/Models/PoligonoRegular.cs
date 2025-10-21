using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class PoligonoRegular : IFigura
    {
        public double Lado { get; }
        public int NumeroLados { get; }
        public double Apotema { get; }

        public PoligonoRegular(double lado, int numeroLados, double apotema)
        {
            if (lado <= 0) throw new ArgumentOutOfRangeException(nameof(lado));
            if (numeroLados < 3) throw new ArgumentOutOfRangeException(nameof(numeroLados));
            if (apotema <= 0) throw new ArgumentOutOfRangeException(nameof(apotema));
            Lado = lado;
            NumeroLados = numeroLados;
            Apotema = apotema;
        }

        public double Perimetro() => Lado * NumeroLados;
        public double Area() => (Perimetro() * Apotema) / 2.0;
    }
}
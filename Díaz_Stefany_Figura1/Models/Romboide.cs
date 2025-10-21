using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class Romboide : IFigura
    {
        public double Base { get; }
        public double Altura { get; }
        public double Lado { get; }

        public Romboide(double baseRomboide, double alturaRomboide, double lado)
        {
            if (baseRomboide <= 0) throw new ArgumentOutOfRangeException(nameof(baseRomboide));
            if (alturaRomboide <= 0) throw new ArgumentOutOfRangeException(nameof(alturaRomboide));
            if (lado <= 0) throw new ArgumentOutOfRangeException(nameof(lado));

            Base = baseRomboide;
            Altura = alturaRomboide;
            Lado = lado;
        }

        public double Area() => Base * Altura;

        // Perímetro de un romboide (paralelogramo): 2 * (base + lado lateral)
        public double Perimetro() => Base + Lado + Base + Lado;
    }
}
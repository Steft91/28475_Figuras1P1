using System;

namespace Actividad2_StefanyDíaz.Models
{
    public class Circulo : IFigura
    {
        public double Radio { get; }

        public Circulo(double radio)
        {
            if (radio <= 0) throw new ArgumentOutOfRangeException(nameof(radio), "El radio debe ser mayor que 0.");
            Radio = radio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
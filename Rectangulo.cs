using FiguraBase;

namespace Plugins
{
    public class Rectangulo : Figura
    {
        double alto, ancho;

        public Rectangulo(double alto, double ancho) : base("Rectangulo")
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public override double Area()
        {
            return alto * ancho;
        }

        public override double Perimetro()
        {
            return 2 * (alto + ancho);
        }
    }
}

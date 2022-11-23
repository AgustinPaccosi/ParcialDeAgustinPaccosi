using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCapasCubo.Entidades
{
    public class Cubo
    {
        public double Arista { get; set; }
        public Colores Color { get; set; }
        public Trazo Trazo { get; set; }
        public double GetArea(double a)
        {
            return 6 * (a * a);
        }
        public double GetVolumen(double a)
        {
            return a * a * a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    class Queso : Alimento
    {

        public Queso(Point posicion, int porcion) : base(posicion, porcion)
        {

        }
        public override void Quitar(int cantidad)
        {
            if (cantidad <= base.porcion)
            {
                base.porcion -= cantidad;
            }
        }

        public override bool Vacio()
        {
            if (base.porcion == 0) { return true; }
            else return false;
        }
    }
}

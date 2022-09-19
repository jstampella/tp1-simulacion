using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    public abstract class Alimento
    {
        private Point posicion;
        protected int porcion;
        private static int nro=0;
        private int numeroIden;
        public Alimento(Point posicion, int porcion)
        {
            this.posicion = posicion;
            this.porcion = porcion;
            nro++;
            numeroIden = nro;
        }

        public Point Posicion
        {
            get { return posicion; }
        }

        public int Nro
        {
            get { return numeroIden; }
        }

        public int Porcion
        {
            get { return porcion; }
        }

        public override string ToString()
        {
            return "nro: "+ numeroIden + " porcion:"+porcion;
        }

        public abstract void Quitar(int cantidad);

        public abstract bool Vacio();

    }
}

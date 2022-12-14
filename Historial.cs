using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    public class Historial
    {
        private Point posicion;
        private int pasos;
        private int diasSinComer;
        private int ingestas;
        private int avance;
        private EEstadoVida estado;

        public Historial(Point posicion, int pasos, int diasSinComer, int ingestas, int avance, EEstadoVida estado)
        {
            this.posicion = posicion;
            this.pasos = pasos;
            this.diasSinComer = diasSinComer;
            this.ingestas = ingestas;
            this.avance = avance;
            this.estado = estado;
        }

        public int Ingestas
        {
            get { return ingestas; }
        }

        public int Dia
        {
            get { return pasos / 10; }
        }

        public int Paso
        {
            get { return pasos % 10; }
        }

        public EEstadoVida Estado
        {
            get { return estado; }
        }

        public int DiasSinComer
        {
            get { return diasSinComer; }
        }
        public int Avance
        {
            get { return avance; }
        }
        public Point Posicion
        {
            get { return posicion; }
        }
    }
}

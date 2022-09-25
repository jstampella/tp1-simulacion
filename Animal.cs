using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    public abstract class Animal
    {
        protected Point posicion;
        private static int nro = 0;
        protected int numeroIden;
        protected int diasSinComer;
        protected int ingestas;
        protected Point limiteArea;
        protected EEstadoVida estado;
        protected int diasDeVida;
        protected int avance;
        protected ArrayList historial = new ArrayList();
        protected int pasos;
        protected static Random random = new Random();

        public Animal(Point posicion, Point limiteArea, int pasosCreado)
        {
            this.posicion = posicion;
            this.diasSinComer = 0;
            this.ingestas = 0;
            this.limiteArea = limiteArea;
            this.estado = EEstadoVida.Nacido;
            this.diasDeVida = 0;
            this.avance = 0;
            this.pasos = pasosCreado;
            nro++;
            numeroIden = nro;
            Historial his = new Historial(posicion, pasosCreado, 0, 0, this.avance, this.estado);
            historial.Add(his);
        }

        #region Propiedades
        public static int NroStatic
        {
            set { nro = value; }
        }

        public Point Posicion
        {
            get { return posicion; }
        }

        public int Nro
        {
            get { return numeroIden; }
        }

        public int DiasSinComer
        {
            get { return diasSinComer; }
        }

        public int Avance
        {
            get { return avance; }
        }

        public int DiasDeVida
        {
            get { return diasDeVida; }
        }

        public EEstadoVida Estado
        {
            get { return estado; }
        }

        public int Pasos
        {
            get { return pasos; }
        }

        #endregion
        public abstract void Mover();
        public abstract void Comer(object obj);
        public abstract void Morir(EEstadoVida estado);
        public abstract bool TieneHambre();
        public abstract ETipoAnimal Soy();
        public abstract ESexo Sexo();
        public abstract override string ToString();
        public Historial[] GetHistorial()
        {
            int count = 0;
            Historial[] hists = new Historial[historial.Count];
            foreach (Historial item in historial)
            {
                hists[count] = item;
                count++;
            }
            return hists;
        }
    }
}

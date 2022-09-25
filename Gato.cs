using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    class Gato : Animal
    {
        private int muertes;

        #region Constructor
        public Gato(Point posicion, Point limiteArea, int pasosCreado) : base(posicion, limiteArea, pasosCreado)
        {
            this.muertes = 0;
        }
        #endregion

        #region propiedades
        public int Muertes
        {
            get { return muertes; }
        }
        #endregion

        #region Matar()
        public void Matar(Object obj)
        {
            //accion matar
            if (obj is Raton aniR)
            {
                aniR.Morir(EEstadoVida.Pelea);
                muertes++;
            }
        }
        #endregion

        #region Comer()
        public override void Comer(object obj)
        {
            if(obj is Raton aniR)
            {
                aniR.Morir(EEstadoVida.Pelea);
                ingestas++;
                diasSinComer = 0;
                muertes++;
            }
        }
        #endregion

        #region Morir()
        public override void Morir(EEstadoVida estado)
        {
            if (estado == EEstadoVida.Inanicion)
            {
                if (diasSinComer > 4)
                {
                    this.estado = estado;
                }
            }
            else
                this.estado = estado;
        }
        #endregion

        #region Mover()
        public override void Mover()
        {
            pasos++;
            if ((pasos % 10) == 0)
            {
                ingestas = 0;
                diasSinComer++;
                diasDeVida++;
            }
            int cant = random.Next(1, 3);
            int direccion = random.Next(1, 5);
            switch (direccion)
            {
                case 1:
                    posicion.X += cant;
                    break;
                case 2:
                    posicion.X -= cant;
                    break;
                case 3:
                    posicion.Y -= cant;
                    break;
                case 4:
                    posicion.Y += cant;
                    break;
                default:
                    break;
            }
            if(posicion.X>limiteArea.X)
                posicion.X = limiteArea.X-1;
            else if(posicion.X<0)
                posicion.X = 0;

            if (posicion.Y > limiteArea.Y)
                posicion.Y = limiteArea.Y - 1;
            else if (posicion.Y <0)
                posicion.Y = 0;
            estado = EEstadoVida.Vivo;
            Historial his = new Historial(posicion, pasos, this.diasSinComer, this.ingestas, this.avance, this.estado);
            historial.Add(his);

        }
        #endregion

        #region Soy()
        public override ETipoAnimal Soy()
        {
            return ETipoAnimal.Gato;
        }
        #endregion

        #region TieneHambre()
        public override bool TieneHambre()
        {
            if (ingestas == 0) return true;
            else return false;
        }
        #endregion

        #region Sexo()
        public override ESexo Sexo()
        {
            return ESexo.Macho;
        }
        #endregion

        public override string ToString()
        {
            return "nro: " + base.numeroIden;
        }
    }
}

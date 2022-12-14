using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    public class Raton : Animal
    {
        public Raton(Point posicion,Point limiteArea, int pasosCreado) : base(posicion,limiteArea, pasosCreado)
        {
        }

        #region Mover()
        public override void Mover()
        {
            pasos++;
            if((pasos % 10) == 0)
            {
                ingestas = 0;
                diasSinComer++;
                diasDeVida++;
            }
            int cant = random.Next(0, 4);
            avance = cant;
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
                    posicion.Y -= cant;
                    break;
                default:
                    break;
            }
            if (posicion.X > limiteArea.X || posicion.X < 0 || posicion.Y > limiteArea.Y || posicion.Y < 0)
                estado = EEstadoVida.Ahogamiento;
            else
                estado = EEstadoVida.Vivo;
            Historial his = new Historial(posicion, pasos, this.diasSinComer, this.ingestas, this.avance, this.estado);
            historial.Add(his);
        }

        #endregion

        #region Mover(pasos, posicion)
        public void Mover(int pasos,Point posicion)
        {
            this.pasos = pasos;
            this.posicion = posicion;
            if (posicion.X > limiteArea.X || posicion.X < 0 || posicion.Y > limiteArea.Y || posicion.Y < 0)
                estado = EEstadoVida.Ahogamiento;
            else
                estado = EEstadoVida.Vivo;
            Historial his = new Historial(posicion, pasos, this.diasSinComer, this.ingestas, this.avance, this.estado);
            historial.Add(his);
        }
        #endregion

        #region Morir()
        public override void Morir(EEstadoVida estado)
        {
            if(estado == EEstadoVida.Inanicion)
            {
                if (diasSinComer > 2)
                {
                    this.estado = estado;
                }
            }
            else
                this.estado = estado;
        }
        #endregion


        public override ETipoAnimal Soy()
        {
            return ETipoAnimal.Raton;
        }

        #region Comer()
        public override void Comer(object obj)
        {
            if(obj is Queso qs)
            {
                qs.Quitar(1);
                ingestas++;
                diasSinComer = 0;
            }
        }
        #endregion

        public override bool TieneHambre()
        {
            //2 veces en un dia
            if (ingestas < 2) return true;
            else return false;
        }

        public override string ToString()
        {
            return "ID:" + numeroIden + " Dias de vida:" + diasDeVida;
        }

        public override ESexo Sexo()
        {
            return ESexo.Macho;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    class Raton : Animal
    {
        public Raton(Point posicion,Point limiteArea, int pasosCreado) : base(posicion,limiteArea, pasosCreado)
        {
        }

        public override void Mover()
        {
            pasos++;
            if((pasos % 10) == 0)
            {
                ingestas = 0;
                diasSinComer++;
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
            Historial his = new Historial(posicion, pasos, this.diasSinComer, this.ingestas, this.avance, this.estado);
            historial.Add(his);
        }

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

        public override ETipoAnimal Soy()
        {
            return ETipoAnimal.Raton;
        }

        public override void Comer(object obj)
        {
            if(obj is Queso qs)
            {
                qs.Quitar(1);
                ingestas++;
                diasSinComer = 0;
            }
        }

        public override bool TieneHambre()
        {
            //2 veces en un dia
            if (ingestas < 2) return true;
            else return false;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override ESexo Sexo()
        {
            return ESexo.Macho;
        }
    }
}

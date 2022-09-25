using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    class IslaPredador : Isla
    {
        private Animal[] predador;
        private int cantPredador;
        public IslaPredador(Point isla, int ratones, int quesos, bool hembra,int gatos) : base(isla, ratones, quesos, hembra)
        {
            this.cantPredador = gatos;
            this.predador = new Animal[gatos];
            CrearGatos(gatos);
        }

        public Historial[] this[int nro, ETipoAnimal tipo]
        {
            get 
            {
                if(ETipoAnimal.Gato == tipo)
                {
                    return predador[nro].GetHistorial();
                }
                else
                {
                    return ((Animal)base.roedores[nro]).GetHistorial();
                }
            }
        }

        public int CantPredador
        {
            get { return cantPredador; }
        }

        public override bool AvanzarPaso()
        {
            base.AvanzarPaso();
            if(estado==EEstado.Iniciado)
            {
                estado = EEstado.SinPredador;
                foreach (Animal item in predador)
                {
                    if (item.Estado == EEstadoVida.Vivo || item.Estado == EEstadoVida.Nacido)
                    {
                        estado = EEstado.Eliminado;
                        item.Mover();
                        foreach (Animal anil in roedores)
                        {
                            if (anil.Estado == EEstadoVida.Vivo)
                            {
                                estado = EEstado.Iniciado;
                                if (item.Posicion == anil.Posicion)
                                {
                                    if (item.TieneHambre())
                                        item.Comer(anil);
                                    else
                                    {
                                        ((Gato)item).Matar(anil);
                                    }
                                }
                            }
                        }
                        //verifica si se muere por hambre
                        item.Morir(EEstadoVida.Inanicion);
                    }
                }
            }
            return (estado == EEstado.Iniciado) ;
        }

        public void CrearGatos(int cant)
        {
            int max = dimensionIsla.X * dimensionIsla.Y;
            for (int i = 0; i < cant; i++)
            {
                Point pos = new Point();
                pos.X = random.Next(0, dimensionIsla.X);
                pos.Y = random.Next(0, dimensionIsla.Y);
                Gato gato = new Gato(pos, dimensionIsla,Pasos);
                predador[i] = gato;

            }
        }

        public Animal VerPredador(int pos)
        {
            return predador[pos];
        }

        public Animal VerPredadorNro(int nro)
        {
            int i = 0;
            int indice = -1;
            Animal nn = null;
            do
            {
                if (((Animal)predador[i]).Nro == nro)
                {
                    indice = i;
                    i = predador.Length + 10;
                }
                i++;
            } while (i < predador.Length);
            if (indice > -1)
            {
                nn = (Animal)predador[indice];
                return nn;
            }
            else
            {
                return nn;
            }
        }

        public int CantPredadorMuertos()
        {
            int cant = 0;
            foreach (Animal item in predador)
            {
                if (item.Estado != EEstadoVida.Vivo) cant++;
            }
            return cant;
        }
    }
}

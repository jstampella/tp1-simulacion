using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    public class Isla
    {
        protected ArrayList roedores = new ArrayList();
        protected ArrayList alimentos = new ArrayList();
        protected int pasos;
        private int cantRoedores;
        private int cantAlimentos;
        protected EEstado estado;
        readonly public Point dimensionIsla;
        protected static Random random = new Random();

        public Isla(Point isla,int ratones,int quesos, bool hembra)
        {
            this.pasos = 0;
            this.estado = EEstado.Iniciado;
            this.dimensionIsla = isla;
            this.cantRoedores = ratones;
            this.cantAlimentos = quesos;
            CrearQuesos(quesos);
            CrearRatones(ratones,hembra);
        }

        public Historial[] this[int nro]
        {
            get
            {
               return ((Animal)roedores[nro]).GetHistorial();
            }
        }

        public int Pasos
        {
            get { return pasos; }
        }

        public int CantRoedores
        {
            get { return cantRoedores; }
        }

        public int CantAlimentos
        {
            get { return cantAlimentos; }
        }

        public EEstado Estado
        {
            get { return estado; }
        }

        public virtual bool AvanzarPaso()
        {
            pasos++;
            ArrayList posiblesBebes = new ArrayList();
            bool bandera = false;
            foreach (Animal item in roedores)
            {
                if(item.Estado == EEstadoVida.Vivo)
                {
                    bandera = true;
                    if (item.Sexo() == ESexo.Hembra)
                    {
                        Raton[] bb = ((Hembra)item).Nacer();
                        if (bb != null)
                        {
                            posiblesBebes.AddRange(bb);
                        }
                    }
                    item.Mover();
                    //verifica si tiene hambre y come
                    if (item.TieneHambre())
                    {
                        int pos = 0;
                        do
                        {
                            Alimento alim = alimentos[pos] as Alimento;
                            if (!alim.Vacio() && item.Posicion == alim.Posicion)
                            {
                                item.Comer(alim);
                                pos = alimentos.Count;
                            }
                            pos++;
                        } while (pos < alimentos.Count);
                    }

                    //recorre para procrear
                    foreach (Animal item2 in roedores)
                    {
                        if (item.Posicion == item2.Posicion && ((Raton)item).Sexo()!= ((Raton)item2).Sexo())
                        {
                            if(item.Sexo()==ESexo.Hembra)
                            {
                                ((Hembra)item).Embarazar();
                            }
                            else
                            {
                                ((Hembra)item2).Embarazar();
                            }
                        }
                    }

                    //verifica si se muere por hambre
                    item.Morir(EEstadoVida.Inanicion);
                }
            }
            roedores.AddRange(posiblesBebes);
            if (posiblesBebes != null)
            {
                CrearQuesos(posiblesBebes.Count/2);
                cantAlimentos = alimentos.Count;
            }
            cantRoedores = roedores.Count;
            if (!bandera && posiblesBebes == null)
                estado = EEstado.Eliminado;
            int roedoresVivos = cantRoedores - CantRoedoresMuertos();
            if (roedoresVivos > dimensionIsla.X * dimensionIsla.Y)
                estado = EEstado.SobrePoblacion;
            else if (roedoresVivos == 0)
            {
                estado = EEstado.Eliminado;
            }
            return bandera;
        }

        public void CrearQuesos(int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Point pos = new Point();
                pos.X = random.Next(0, dimensionIsla.X);
                pos.Y = random.Next(0, dimensionIsla.Y);
                Queso queso = new Queso(pos, 2);
                alimentos.Add(queso);
                
            }
        }

        public void CrearRatones(int cant,bool hembra)
        {
            int max = dimensionIsla.X * dimensionIsla.Y;
            int tipo;
            for (int i = 0; i < cant; i++)
            {
                Point pos = new Point();
                pos.X = random.Next(0, dimensionIsla.X);
                pos.Y = random.Next(0, dimensionIsla.Y);
                tipo = random.Next(0, 2);
                if (tipo == 1 && hembra)
                {
                    Hembra raton = new Hembra(pos, dimensionIsla, pasos);
                    roedores.Add(raton);
                }
                else
                {
                    Raton raton = new Raton(pos, dimensionIsla, pasos);
                    roedores.Add(raton);
                }
            }
        }

        public void AgregarRatones(Raton[] ratones)
        {

        }

        public Animal VerRoedores(int pos)
        {
            return (Animal)roedores[pos];
        }

        public Animal VerRoedoresNro(int nro)
        {
            int i = 0;
            int indice = -1;
            Animal nn = null;
            do
            {
                if (((Animal)roedores[i]).Nro == nro)
                {
                    indice = i;
                    i = roedores.Count + 10;
                }
                i++;
            } while (i < roedores.Count);
            if(indice > -1)
            {
                nn = (Animal)roedores[indice];
                return nn;
            }
            else
            {
                return nn;
            }
        }

        public Alimento VerAlimento(int pos)
        {
            return (Alimento)alimentos[pos];
        }

        public Alimento VerAlimentoNro(int nro)
        {
            int i = 0;
            int indice = -1;
            Alimento nn = null;
            do
            {
                if (((Alimento)alimentos[i]).Nro == nro)
                {
                    indice = i;
                    i = alimentos.Count + 10;
                }
                i++;
            } while (i < alimentos.Count);
            if (indice > -1)
            {
                nn = (Alimento)alimentos[indice];
                return nn;
            }
            else
            {
                return nn;
            }
        }

        public int CantAlimentosDisponible()
        {
            int cant = 0;
            foreach (Alimento item in alimentos)
            {
                if (item.Vacio()) cant++;
            }
            return cant;
        }

        public int CantRoedoresMuertos()
        {
            int cant = 0;
            foreach (Animal item in roedores)
            {
                if (item.Estado != EEstadoVida.Vivo) cant++;
            }
            return cant;
        }
    }
}

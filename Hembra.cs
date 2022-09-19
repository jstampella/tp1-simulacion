using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    class Hembra :Raton
    {
        private Raton[] bebes;
        private int diasGestacion;

        public Hembra(Point posicion,Point limiteArea,int pasosCreado) : base(posicion,limiteArea,pasosCreado)
        {
            diasGestacion = 0;
        }

        public int DiasGestacion
        {
            get { if (diasGestacion!=0 && (pasos - diasGestacion) >= 0) return pasos - diasGestacion; else return 0; }
        }

        public int CantBebes
        {
            get { if (bebes != null) return bebes.Length; else return 0; }
        }

        public void Embarazar()
        {
            //accion para crear bebes
            if(diasGestacion == 0)
            {
                diasGestacion = pasos;
                int cant = random.Next(2, 7);
                bebes = new Raton[cant - 1];
                for (int i = 0; i < bebes.Length; i++)
                {
                    int tipo = random.Next(0, 2);
                    if (tipo == 1)
                    {
                        Hembra bb = new Hembra(posicion, limiteArea, pasos);
                        bebes[i] = bb;
                    }
                    else
                    {
                        Raton bb = new Raton(posicion, limiteArea, pasos);
                        bebes[i] = bb;
                    }
                }
            }
        }

        public Raton[] Nacer()
        {
            if (pasos - diasGestacion == 10)
            {
                diasGestacion = 0;
                Raton[] bb = bebes;
                bebes = null;
                return bb;
            }   
            else
            {
                Raton[] ret = null;
                return ret;
            }
        }

        public override ESexo Sexo()
        {
            return ESexo.Hembra;
        }
    }
}

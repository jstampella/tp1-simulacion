using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_simulacion
{
    interface IAnimal
    {
        void Mover();
        void Comer(Object obj);
        void Morir(EEstadoVida estado);
        bool TieneHambre();
        string ToString();
        ETipoAnimal Soy();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaChainOfResponsability
{
    public abstract class Aprobador
    {
        protected Aprobador _siguiente;

        public void AsignarResponsabilidad(Aprobador aprobador)
        {
            _siguiente = aprobador;
        }

        public abstract void Procesar(Compra c);
    }
}

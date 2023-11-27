using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaChainOfResponsability
{
    public class Gerente : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if(c.Importe <= 100000)
            {
                Console.WriteLine(string.Format("La compra fue aprobada por el {0}", this.GetType().Name));
            }
            else
            {
                _siguiente.Procesar(c);
            }
        }
    }
}

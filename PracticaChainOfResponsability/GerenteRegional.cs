using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaChainOfResponsability
{
    public class GerenteRegional : Aprobador
    {
        public override void Procesar(Compra c)
        {
            Console.WriteLine(string.Format("La compra fue aprobada por el {0}", this.GetType().Name));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaChainOfResponsability
{
    public class Vendedor : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if(c.Importe < 1000)
            {
                if(c.Importe != 0)
                {
                    Console.WriteLine(string.Format("La compra fue aprovada por el {0}", this.GetType().Name));
                }
                else
                {
                    Console.WriteLine("La compra a finalizado");    
                }
            }
            else
            { 
                _siguiente.Procesar(c);
                
            }
            
        }
    }
}

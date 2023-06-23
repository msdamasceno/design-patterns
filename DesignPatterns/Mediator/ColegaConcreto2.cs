using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ColegaConcreto2: Colega
    {
        public ColegaConcreto2(Mediator mediator) : base(mediator)
        {
        }

        public void Enviar(string mensagem)
        {
            mediator.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do Colega 2: " + mensagem);
        }
    }
}

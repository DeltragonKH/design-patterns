using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Papagaio : IAjuda
    {
        public string Ajudar(Ajuda pedido)
        {
            return "Sou um papagaio e posso ajudar voce a voar!";
        }
    }
}

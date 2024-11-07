using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Sapo : IAjuda
    {
        public string Ajudar(Ajuda pedido)
        {
            return "Sou um sapo e posso ajudar voce a pular";
        }
    }
}

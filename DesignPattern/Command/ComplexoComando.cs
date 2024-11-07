using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ComplexoComando : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComplexoComando(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Executar()
        {
            this._receiver.PrimeiroPedido(_a);
            this._receiver.SegundoPedido(_b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controle controle = new Controle();
            //controle.EnviarComandoSimples(new SimplesCOmando("Dizer oi"));

            Receiver receiver = new Receiver();
            controle.EnviarComandoComplexo(new ComplexoComando(receiver, "Abastecer o carro", "Calibrar o pneu"));


            controle.Fazer();
            Console.ReadKey();
        }
    }
}

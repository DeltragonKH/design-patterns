using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criar o mediador
            MediadorConcreto mediador = new MediadorConcreto();

            // Criar os colaboradores e passar o mediador para eles
            ColaboradorA colaboradorA = new ColaboradorA(mediador);
            ColaboradorB colaboradorB = new ColaboradorB(mediador);

            // Registrar os colaboradores no mediador
            mediador.SetColaboradorA(colaboradorA);
            mediador.SetColaboradorB(colaboradorB);

            // Testar a comunicação
            colaboradorA.EnviarMensagem("Olá, Colaborador B!");
            colaboradorB.EnviarMensagem("Olá, Colaborador A!");
        }
    }
}

    


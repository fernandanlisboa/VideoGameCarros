using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    public class ControleEletronico : RecursoDecorator
    {
        public ControleEletronico(Carro carro)
        {
            this.carro = carro;
        }


        public override string getDescricao()
        {
            return carro.getDescricao() + "\n\tControle eletrônico\n";
        }

        public override double custo()
        {
            return 1000 + carro.custo();
        }
    }
}

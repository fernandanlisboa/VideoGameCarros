using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class FarolLED : RecursoDecorator
    {
        public FarolLED(Carro carro)
        {
            this.carro = carro;
        }

        public override string getDescricao()
        {
            return carro.getDescricao() + "\n\tFarol de LED\n";
        }

        public override double custo()
        {
            return 500 + this.carro.custo();
        }
    }
}

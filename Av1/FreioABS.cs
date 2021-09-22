using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class FreioABS : RecursoDecorator
    {
        public FreioABS(Carro carro)
        {
            this.carro = carro;
        }

        public override string getDescricao()
        {
            return carro.getDescricao() + "\n\tFreio ABS\n";
        }


        public override double custo()
        {
            return 2500 + this.carro.custo();
        }
    }
}

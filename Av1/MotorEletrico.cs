using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class MotorEletrico : RecursoDecorator
    {
        public MotorEletrico(Carro carro)
        {
            this.carro = carro; 
        }

        public override string getDescricao()
        {
            return carro.getDescricao() + "\n\tMotor elétrico\n";
        }

        public override double custo()
        {
            return 20000 + this.carro.custo();
        }
    }
}

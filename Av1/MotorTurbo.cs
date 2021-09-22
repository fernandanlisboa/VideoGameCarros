using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class MotorTurbo : RecursoDecorator
    {
        public MotorTurbo(Carro carro)
        {
            this.carro = carro;
        }

        public override string getDescricao()
        {
            return carro.getDescricao() + "\n\tMotor Turbo\n";
        }

        public override double custo()
        {
            return 10000 + this.carro.custo();
        }
    }
}

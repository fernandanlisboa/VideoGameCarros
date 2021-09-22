using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class CapotaConversivel : RecursoDecorator
    {
        public CapotaConversivel(Carro carro)
        {
            this.carro = carro;
        }

        public override string getDescricao()
        {
            return carro.getDescricao() + "\n\tCapota Conversível\n";
        }

        public override double custo()
        {
            return 12000 + this.carro.custo();
        }
    }
}

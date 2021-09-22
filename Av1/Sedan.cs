using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class Sedan : Carro
    {
        public Sedan()
        {
            Descricao = "Sedan";
        }

        public override double custo()
        {
            return 45000;
        }
    }
}

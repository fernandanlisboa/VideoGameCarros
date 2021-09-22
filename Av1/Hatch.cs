using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class Hatch : Carro
    {
        public Hatch()
        {
            Descricao = "Carro Hatch";
        }         

        public override double custo()
        {
            return 30000;
        }
    }
}

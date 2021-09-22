using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    class SUV : Carro
    {
        public SUV()
        {
            Descricao = "SUV";
        }

        public override double custo()
        {
            return 65000;
        }
    }
}

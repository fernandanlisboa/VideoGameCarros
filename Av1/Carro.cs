using System;
using System.Collections.Generic;
using System.Text;

namespace Av1
{
    public abstract class Carro
    {
       
        public string Descricao = "Carro desconhecido";
        public float Preco;


        public virtual string getDescricao()
        {
            return Descricao;
        }

        public abstract double custo();
    }
}

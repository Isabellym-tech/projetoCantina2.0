using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCantina2._0
{
    internal class Produtos // cria a classe e o que vai ter dentro dela 
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int Quantidade { get; set;}


        public Produtos (string nome, decimal preco, int quantidade) // metodo construtor 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }



        public override string ToString() // método que retorna uma representação em string do objeto.
        {
            if (Quantidade == 0)
            {
                return $"{Nome} - R$ {Preco:F2}"; // formata o preço com duas casas decimais.
            }

            else
            {
                return $"{Quantidade} x {Nome} - R$ {Preco:F2}"; // formata o preço com duas casas decimais.
            }
        }

    }


}

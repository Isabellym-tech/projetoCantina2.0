using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCantina2._0
{
    internal class Produtos // cria a classe e o que vai ter dentro dela 
    {
        private string Nome { get; set; }
        private decimal Preco { get; set; }

        private int Quantidade { get; set;}


        public Produtos (string nome, decimal preco, int quantidade) // metodo construtor 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public override string ToString()
        {
            return $"{Nome},  {Preco}, {Quantidade}";
        }
      
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCantina2._0
{
    internal class Produtos
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
    }
}

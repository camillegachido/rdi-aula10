using System;
using System.Collections.Generic;
using System.Linq;
namespace FastFoodSystem
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Estoque { get; set; }

        public Produto(int id, string nome, decimal valor, int estoque)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Estoque = estoque;
        }
    }
}

//Nesta parte do sistema, está definida a classe Produto dentro do namespace FastFoodSystem. 
//Ela possui quatro propriedades que descrevem o item: 
//um identificador único, o nome, o preço (usando decimal para precisão financeira)
 //e a quantidade em estoque. Além disso, implementamos um construtor que garante 
 //que todo produto seja criado já com seus dados básicos preenchidos, facilitando 
 //a integridade dos dados no restante da aplicação.
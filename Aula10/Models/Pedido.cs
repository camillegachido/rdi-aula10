]using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public Usuario Usuario { get; set; }
        public List<Produto> Produtos { get; set; }

        public Pedido(Usuario usuario)
        {
            DataHora = DateTime.Now;
            Usuario = usuario;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto) {
            Produtos.Add(produto);
        }

        public decimal CalcularTotal() {
            decimal total = 0;
            foreach (var produto in Produtos) {
                total += produto.Valor;
            }
            return total;
        }

        public void FinalizarPedido()
        {
            if(Produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto adicionado ao pedido.");
                return;
            }

            Console.WriteLine("Resumo do pedido:");  
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Valor: {produto.Valor}");
            }

            Console.WriteLine($"Total do pedido: {CalcularTotal()}");
        }
    }
}

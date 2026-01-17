using System;
using System.Collections.Generic;

namespace Aula10
{
    public class Restaurante
    {
        public List<Produto> Produtos { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Restaurante()
        {
            Produtos = new List<Produto>();
            Pedidos = new List<Pedido>();
        }

        public void CadastrarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public Produto? BuscarProdutoPorId(int id)
        {
            return Produtos.FirstOrDefault(p => p.Id == id);
        }

        public void ListarProdutosDisponiveis()
        {
            Console.WriteLine("--- Cardápio ---");
            foreach (var produto in Produtos)
            {
                if (produto.QtdEstoque > 0)
                {
                    Console.WriteLine($"{produto.Id} - {produto.Nome} (R$ {produto.Valor:C}) - Estoque: {produto.QtdEstoque}");
                }
            }
        }
    }
}
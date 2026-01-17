using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10.Models
{
    public class Restaurante
    {
        public List<Produto> Produtos = new List<Produto>();
        public List<Pedido> Pedidos = new List<Pedido>();

        public Restaurante()
        {
            Produtos = new List<Produto>();
            Pedidos = new List<Pedido>();
        }

        public void CadastrarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public Produto BuscarProdutoPorId(int id)
        {
            //return Produtos.Find(p => p.Id == id);
            foreach (var produto in Produtos)
            {
                if (produto.Id == id)
                {
                    return produto;
                }
            }

            return null;
        }

        public void ListarProdutosDisponiveis()
        {
            if (Produtos.Count <= 0)
            {
                Console.WriteLine("Nenhum produto disponível.");
                return;
            }

            Console.WriteLine("Produtos disponíveis:");
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Valor: {produto.Valor}");
            }


        }
    }
}

using System;
using System.Collections.Generic;
namespace Aula10
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Hora { get; set; }
        public Usuario? Usuario { get; set; }
        public List<(Produto Produto, int Quantidade)> Produtos { get; set; }

        public Pedido()
        {
            Hora = DateTime.Now;
            Produtos = new List<(Produto, int)>();
        }

        public void AdicionarProduto(Produto produto, int quantidade)
        {
            Produtos.Add((produto, quantidade));
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Produtos)
            {
                total += item.Produto.Valor * item.Quantidade;
            }
            return total;
        }

        public void FinalizarPedido(bool resumo = false)
        {
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Não é possível finalizar um pedido sem produtos.");
                return;
            }
            Console.WriteLine("--- Resumo do Pedido ---");
            foreach (var item in Produtos)
            {
                Console.WriteLine($"{item.Produto.Nome} x{item.Quantidade} - R$ {item.Produto.Valor * item.Quantidade:C}");
            }
            Console.WriteLine($"Total: R$ {CalcularTotal():C}");
            if (!resumo)
                Console.WriteLine("Seu pedido estará pronto em breve!\n");
        }
    }
}
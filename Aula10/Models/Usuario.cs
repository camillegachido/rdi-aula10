using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public List<Pedido> Pedidos = new List<Pedido>();

        public Usuario(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Pedidos = new List<Pedido>();
        }

        public void FazerPedido(Restaurante restaurante, Pedido pedido)
        {
            pedido.Usuario = this;
            Pedidos.Add(pedido);
            restaurante.Pedidos.Add(pedido);
        }

        public void VerPedidosAnteriores()
        {
            if(Pedidos.Count == 0)
            {
                Console.WriteLine("Nenhum pedido anterior encontrado.");
                return;
            }

            Console.WriteLine($"Pedidos anteriores de {Nome}:");

            foreach (var pedido in Pedidos)
            {
                Console.WriteLine($"Pedido ID: {pedido.Id}, Data e Hora: {pedido.DataHora}, Produto: {pedido.Produtos}");
            }
        }
    }
}

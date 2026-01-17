using System;
using System.Collections.Generic;

namespace FastFoodSystem
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Usuario(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Pedidos = new List<Pedido>();
        }

        public void FazerPedido(Restaurante restaurante, Pedido pedido)
        {
            pedido.Usuario = this; //
            Pedidos.Add(pedido);
            restaurante.Pedidos.Add(pedido);
        }

        public void VerPedidosAnteriores()
        {
            if (Pedidos.Count == 0)
            {
                Console.WriteLine("Nenhum pedido realizado ainda.");
                return;
            }

            foreach (Pedido pedido in Pedidos)
            {
                Console.WriteLine($"Pedido #{pedido.Id} - {pedido.Hora}");
            }
        }
    }
}

using System.Runtime.CompilerServices;

public class Usuario
{
    public string Nome { get; private set; }
    public string Telefone { get; private set; }
    public List<Pedido> Pedidos { get; private set; }

    public Usuario(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
        Pedidos = new List<Pedido>();
    }

    public void FazerPedido(Restaurante restaurante, Pedido pedido)
    {
        if (restaurante == null || pedido == null)
            return;

        // associa o pedido ao usuário
        pedido.Usuario = this;

        // adiciona o pedido à lista do usuário
        Pedidos.Add(pedido);

        // adiciona o pedido ao restaurante
        restaurante.Pedidos.Add(pedido);
    }

    public void VerPedidosAnteriores()
    {
        if (Pedidos.Count == 0)
        {
            Console.WriteLine("Nenhum pedido realizado.");
            return;
        }

        foreach (var pedido in Pedidos)
        {
            Console.WriteLine($"\nPedido #{pedido.Id} - {pedido.Hora}");
            foreach(var produto in pedido.Produtos)
            {
                Console.WriteLine($"- {produto.Nome} (R$ {produto.Valor})");
            }
            Console.WriteLine($"Total: R$ {pedido.CalcularTotal()}");
        }
    }
}

public class Usuario
{
    public string Nome { get ; set; }
    public string Telefone { get; set; }
    public List<Pedido> Pedidos { get ; set; }



    public Usuario (string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public void FazerPedido(Restaurante restaurante, Pedido pedido)
        {
            Pedidos.Add(pedido);
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
                pedido.FinalizarPedido();
                Console.WriteLine("--");
            }
        }
}




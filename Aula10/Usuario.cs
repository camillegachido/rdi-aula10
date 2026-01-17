namespace Aula10;
public class Usuario


{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();


    public Usuario(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }


    //Fazer Pedidos dentro do Usuario
   public void FazerPedido(Restaurante restaurante, Pedido pedido)
        {
            // Associa o pedido ao usuário
            this.Pedidos.Add(pedido);


            // Adiciona o pedido à lista do restaurante
            restaurante.AdicionarPedido(pedido);


            Console.WriteLine($"Pedido de {Nome} enviado para o restaurante.");
        }


    public void VerPedidosAnteriores()
        {
            if (Pedidos.Count == 0)
                {
                    Console.WriteLine("\nVocê ainda não fez nenhum pedido.\n");
                    return;
                }


        Console.WriteLine("\n=== Seus pedidos anteriores ===");
        foreach (var p in Pedidos)
            {
            Console.WriteLine(p.ResumoDetalhado());
            }
            Console.WriteLine();
        }
}

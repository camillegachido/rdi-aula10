using System;

class Pedido
{
    public int Id { get; set; }
    public DateTime Hora { get; set; } = DateTime.Now;
    public Usuario PedidoUsuario { get; set; }

    public List<Produto> Produtos { get; set; }

    public Pedido(int id)
    {
        Id = id;
              
    }
     
    //Adicionar produto
    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void CalcularValorTotal()
    {
        decimal valorTotal = 0;
        foreach (var produto in Produtos)
        {
            valorTotal += produto.Valor;
        }
        Console.WriteLine($"Valor total do pedido: R$ {valorTotal}");
    }
           public bool FinalizarPedido()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("\nNão dá pra finalizar: seu pedido não tem produtos.\n");
            return false;
        }

        Console.WriteLine("\nPedido finalizado com sucesso!");
        Console.WriteLine(ResumoDetalhado());
        return true;
    }
             public string ResumoDetalhado()
     {
          return $"Pedido ID: {Id}, Hora: {Hora}, Total de Produtos: {Produtos.Count}";
     }
}
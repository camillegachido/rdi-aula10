using System;
class Restaurante
{
    public List<Produto> Produtos { get; set; }
    public List<Pedido> Pedidos { get; set; }


    public void CadastrarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void BuscarProdutoPorId(int id)
    {
        foreach (var produto in Produtos)
        {
            if (produto.Id == id)
            {
                Console.WriteLine($"Produto encontrado: {produto.Nome}, Valor: R$ {produto.Valor}");
                return;
            }
        }
        Console.WriteLine("Produto não encontrado.");
    }

    public void ProdutosDisponiveis()
    {
        Console.WriteLine("=== Produtos Disponíveis ===");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Valor: R$ {produto.Valor}");
        }
    }

    internal void AdicionarPedido(Pedido pedido)
    {
        Pedidos.AddRange();
    }
}



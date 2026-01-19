using System;

public class Pedido
{
    Random rnd = new Random();

    public Pedido(Usuario usuario)
    {
        (Usuario) = (usuario);

        Id = rnd.Next();
        Hora = DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss");
        Produtos = new List<Produto>();
    }

    public int Id { get; }
    public string Hora {get; set;}
    public Usuario Usuario {get; set;}
    public List<Produto> Produtos { get; set; }

    public void AdicionarProduto(Produto produto)
    {
        if(produto != null)
            Produtos.Add(produto);
    }

    public double CalcularTotal()
    {
        double total = 0;
        foreach (Produto produto in Produtos)
        {
            total += produto.Valor;
        }

        return total;
    }

    public void FinalizarPedido()
    {
        Console.WriteLine("\n");
        if(Produtos.Count > 0)
        {
            Console.WriteLine("Pedido Finalizado\n");
            Console.WriteLine($"Total: R$ {CalcularTotal()} \n");

            Console.WriteLine("Resumo do Pedido\n");
            for(int i=0; i < Produtos.Count; i++)
            {
                Console.WriteLine($"{Produtos[i].Nome} - R$: {Produtos[i].Valor}");              
            }
            Console.WriteLine("\n");
        }
    }

}
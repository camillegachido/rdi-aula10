using System;
using System.Numerics;
using System.Security.Cryptography;

internal class Pedido
{
    Random rnd = new Random();
    
    public Pedido(Usuario usuario)
    {
        (Usuario) = (usuario);

        Id = rnd.Next();
        Hora = DateTime.Now.ToString("dd mm yyyy,hh:mm:ss");
        Produto[] Produtos = [];
        Total = 0;
    }

    public int Id { get; }
    public string Hora {get; set;}
    public Usuario Usuario {get; set;}
    public Produto[] Produtos {get; set;}
    public double Total {get; set;}

    public void AdicionarProduto(Produto produto)
    {
        _ = Produtos.Append(produto);
    }

    public double CalcularTotal()
    {
        foreach (Produto produto in Produtos)
        {
            Total += produto.Valor;
        }

        return Total;
    }

    public void FinalizarPedido()
    {
        if(Produtos.Length > 0)
        {
            Console.WriteLine("Pedido Finalizado\n");
            Console.WriteLine($"Total: {Total} \n");
            Console.WriteLine("Pedido Finalizado\n");
        }
    }

}
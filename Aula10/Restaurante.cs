using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10;

public class Restaurante
{
    public List<Produto> Produtos { get; set; }
    public List<Pedido> Pedidos { get; set; }


    public Restaurante()
    {
        Produtos = new List<Produto>();
        Pedidos = new List<Pedido>();

    }

    public void CadastrarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public Produto BuscarProdutoPorId(int id)
    {
        if (Produtos.Count > 0)
        {
            return Produtos[0];
        }

        return null;
    }

    public void ListarProdutosDisponiveis()
    {
        for (int i = 0; i < Produtos.Count; i++)
        {
            Console.WriteLine($"{Produtos[i].Id} - {Produtos[i].Nome} - R$ {Produtos[i].Valor}");
        }
    }
}

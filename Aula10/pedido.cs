using System;
using System.Collections.Generic;
using System.Linq;
using FastFoodSystem;

class Pedido
{
    public int Id { get; set; }
    public DateTime Hora { get; set; }
    public Usuario Usuario { get; set; } 
    public List<Produto> Produtos { get; set; }
    public Pedido(int id, Usuario usuario)
    {
        Id = id;
        Hora = DateTime.Now;
        Usuario = usuario;
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public decimal CalcularTotal()
    {
        return Produtos.Sum(p => p.Valor);
    }

 
    public bool Finalizacao()
    {
        return Produtos.Count > 0;
    }
}
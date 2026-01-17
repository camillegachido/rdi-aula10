using System;
using System.Collections.Generic;
using System.Data;

public class Pedidos
{
    public int Id { get; set; }
    public DateTime Hora { get; set; }
    public Usuario Usuario { get; set; }
    public List<Produto> Produtos { get; set; }


    public Pedidos(int id, Usuario usuario)
    {
        Id = id;
        Usuario = usuario;
        Hora = DateTime.Now;
        Produtos = new List<Produto>();
    }
    public void AdicionarProduto(Produto produto){
    Produtos.Add(produto);
    Console.WriteLine($"> {produto.Nome} adicionado ao pedido.");
}

    public decimal CalcularTotal(){
    return Produtos.Sum(p => (p.Valor).ToFixed(2));
    }

    public void FinalizarPedido(){
        if (Produtos.Count == 0)
    {
        Console.WriteLine("Erro: O pedido precisa ter pelo menos um produto.");
        return false;
    }

    Console.WriteLine("*** Resumo do Pedido ***");
    Console.WriteLine($"Pedido #{Id} | Cliente: {Usuario.Nome}");
    Console.WriteLine("Itens:");
    
    foreach (var item in Produtos)
    {
        Console.WriteLine($" - {item.Nome}: {item.Valor:C}");
    }
    
    Console.WriteLine($"TOTAL: {CalcularTotal():C}");
    return true;
}
}
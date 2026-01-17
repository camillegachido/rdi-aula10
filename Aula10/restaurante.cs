using System.Collections.Generic;
using System.Linq;
using FastFoodSystem;

class Restaurante
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
        return Produtos.FirstOrDefault(p => p.Id == id);
    }

    public List<Produto> ListarProdutosDisponiveis()
    {
        return Produtos; 
    }
}

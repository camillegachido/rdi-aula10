namespace Aula10;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Hora { get; set; } = DateTime.Now;

    public Usuario? Usuario { get; private set; }  // pode ser definido depois
    public List<Produto> Produtos { get; set; } = new List<Produto>();

    public Pedido(int id)
        {
            Id = id;
            Hora = DateTime.Now;
            Produtos = new List<Produto>();
        }

    public Pedido(int id, Usuario usuario) : this(id)
        {
            DefinirUsuario(usuario);
        }

    public void DefinirUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

    public void AdicionarProduto(Produto produto)
        {
            if (produto == null)
            {
                Console.WriteLine("Produto inválido.");
                return;
            }
            Produtos.Add(produto);
        }

    public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0m;
            foreach (var produto in Produtos)
            {
                valorTotal += produto.Valor; // precisa ser decimal no Produto
            }
            return valorTotal;
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
            return $"Pedido ID: {Id}, Hora: {Hora:HH:mm}, Total: R$ {CalcularValorTotal():F2}, Produtos: {Produtos.Count}";
        }

    public string ResumoSimples()
        {
            return $"Pedido #{Id} | {Hora:dd/MM HH:mm} | R$ {CalcularValorTotal():F2} | Itens: {Produtos.Count}";
        }
}

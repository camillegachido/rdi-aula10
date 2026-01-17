
public class Usuario
{
    public string Nome { get ; set; }
    public string Telefone { get; set; }
    public List<Pedido> Pedidos { get ; set; }



    public Usuario (string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }



}

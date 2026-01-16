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

    






}




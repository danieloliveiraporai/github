﻿namespace Comex.Modelos.Produtos;

internal class Eletronico : Produto
{
    public Eletronico(string nome) : base(nome)
    {
    }

    public int Voltagem { get; set; }
    public int Potencia { get; set; }
}

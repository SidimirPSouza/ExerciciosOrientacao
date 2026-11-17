using System;
using System.Collections.Generic;
using System.Text;

public class Livro
{
    public Livro(string titulo, string autor, uint numPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumPaginas = numPaginas;
    }

    public string Titulo;
    public string Autor;
    public uint NumPaginas;

    public string GetTitulo()
    {
        return this.Titulo;
    }
    public string GetAutor()
    {
        return this.Autor;
    }
    public uint GetNumPaginas()
    {
        return this.NumPaginas;
    }

    public override string ToString()
    {
        return $"Nome do livro: {Titulo} \nAutor: {Autor} \nNúmero de paginas: {NumPaginas}";
    }

}


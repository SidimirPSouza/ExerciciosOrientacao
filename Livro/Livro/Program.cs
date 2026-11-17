Console.WriteLine("Informe a quantidade de livros que deseja inserir: ");
int quant = int.Parse(Console.ReadLine());
Livro[] livros = new Livro[quant];

for (int i = 0; i < quant; i++)
{
    Console.WriteLine("\nInforme o titulo do livro: ");
    var titulo = Console.ReadLine();
    Console.WriteLine("Informe o autor do livro: ");
    var autor = Console.ReadLine();
    int numPaginas = 0;
    while (numPaginas <= 0)
    {
        Console.WriteLine("Informe o numero de paginas do livro: ");
        numPaginas = int.Parse(Console.ReadLine());
        if (numPaginas > 0)
        {
            uint num = checked((uint)numPaginas);
            livros[i] = new Livro(titulo, autor, num);
        }
        else
            Console.WriteLine("O numero de paginas do livro deve ser maior q zero: ");
    }
}

for (int i = 0; i < quant; i++)
{
    Console.WriteLine(livros[i].ToString() + "\n");

}




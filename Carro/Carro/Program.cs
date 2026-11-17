using System.Globalization;

int tam = 2;

Carro[] carros = new Carro[tam];
Motor CadastrarMotor()
{
    Console.WriteLine("\nInforme os atributos motor do carro que deseja inserir: ");
    Console.WriteLine("Tipo de Combustivel: ");
    string tipoCombustivel = Console.ReadLine();

    Console.WriteLine("CC: ");
    int cc = int.Parse(Console.ReadLine());

    Console.WriteLine("Pôtencia: ");
    string potencia = Console.ReadLine();

    Motor motor = new Motor(tipoCombustivel,cc,potencia);

    return motor;
}

Carro CadastrarCarro()
{
    Console.WriteLine("\nInforme os atributos carro que deseja inserir: ");
    Console.WriteLine("Marca: ");
    string marca = Console.ReadLine();

    Console.WriteLine("modelo: ");
    string modelo = Console.ReadLine();

    Console.WriteLine("anoFabricacao: ");
    int anoFabricacao = int.Parse(Console.ReadLine());

    Console.WriteLine("anoModelo: ");
    int anoModelo = int.Parse(Console.ReadLine());

    Console.WriteLine("valorVenda: ");
    double valorVenda = double.Parse(Console.ReadLine());

    Motor motor = CadastrarMotor();

    Carro carro = new(marca, modelo, anoFabricacao, anoModelo, valorVenda, motor);

    return carro;
}

void CalculoIpva(int anoFabricacao, double valorVenda)
{
    int anoAtual = DateTime.Now.Year;
    if ((anoAtual - anoFabricacao) < 20)
    {
        double ipva = valorVenda * 0.04;
        CultureInfo culturaPtBr = new CultureInfo("pt-BR");
        string ipvaFormatado = ipva.ToString("C", culturaPtBr);
        Console.WriteLine($"O valor de IPVA do carro é: {ipvaFormatado}");
    }
    else
    {
        Console.WriteLine("Carro com 20 anos ou mais, não paga IPVA");
    }
}

for (int i = 0; i < tam; i++)
{
    var carro = CadastrarCarro();
    carros[i] = carro;
}

for (int i = 0; i < tam; i++)
{
    Console.WriteLine("\n" + carros[i].ToString());
    CalculoIpva(carros[i].AnoFabricacao, carros[i].ValorVenda);
}



Console.ReadKey();
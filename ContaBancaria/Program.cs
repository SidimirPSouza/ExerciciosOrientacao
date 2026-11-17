ContaBancaria conta = new ContaBancaria();

conta.SetTitular("Sidimir H. Paula Souza");
conta.SetSaldo(1000);

int menu = 10;
while (menu != 0)
{
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - consultar");
    Console.WriteLine("0 - Sair");
    menu = int.Parse(Console.ReadLine());
    if (menu == 1)
    {
        Console.WriteLine("Digite o valor que deseja depositar");
        conta.DepositarSaldo(double.Parse(Console.ReadLine()));
    }
    else if (menu == 2)
    {
        Console.WriteLine("Digite o valor que deseja sacar");
        conta.SacarSaldo(double.Parse(Console.ReadLine()));
    }
    else if (menu == 3)
    {
        Console.WriteLine(conta.ExibirSaldo());
    }
    else if (menu != 0)
    {
        Console.WriteLine("Opção invalida! Por favor insira uma opção valida");
    }
    else
    {
        Console.WriteLine("Espero que tenha tido um ótimo atendimento, até mais!");
    }
}


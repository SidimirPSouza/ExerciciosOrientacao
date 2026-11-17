using System.Globalization;

public class ContaBancaria
{
    public string Titular;
    public double Saldo;


    public string GetTitular()
    {
        return this.Titular;
    }

    public void SetTitular(string titular)
    {
        Titular = titular;
    }

    public double GetSaldo()
    {
        return this.Saldo;
    }

    public void SetSaldo(double saldo)
    {
        Saldo = saldo;
    }

    public void DepositarSaldo(double deposito)
    {
        GetSaldo();
        Saldo += deposito;
    }

    public void SacarSaldo(double saque)
    {
        GetSaldo();
        Saldo -= saque;
    }

    public string ExibirSaldo()
    {
        CultureInfo culturaPtBr = new CultureInfo("pt-BR");
        string saldoFormatado = Saldo.ToString("C", culturaPtBr);
        return $"Saldo: {saldoFormatado}";
    }

    public override string ToString()
    {
        return "Titular: " + Titular + "\nSaldo: " + Saldo;
    }
}


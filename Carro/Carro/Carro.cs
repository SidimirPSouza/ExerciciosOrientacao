using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public class Carro
{
    public Carro(string marca, string modelo, int anoFabricacao, int anoModelo, double valorVenda, Motor motor)
    {
        Marca = marca;
        Modelo = modelo;
        AnoFabricacao = anoFabricacao;
        AnoModelo = anoModelo;
        ValorVenda = valorVenda;
        Motor = motor;
    }
    public string Marca;
    public string Modelo;
    public int AnoFabricacao;
    public int AnoModelo;
    public double ValorVenda;
    public Motor Motor;

    public void SetMarca(String marca)
    {
        Marca = marca;
    }
    public string GetMarca()
    {
        return this.Marca;
    }
    public void SetModelo(String modelo)
    {
        Modelo = modelo;
    }
    public string GetModelo()
    {
        return this.Modelo;
    }
    public void SetAnoFabricacao(int anoFabricacao)
    {
        AnoFabricacao = anoFabricacao;
    }
    public int GetAnoFabricacao()
    {
        return this.AnoFabricacao;
    }
    public void SetAnoModelo(int anoModelo)
    {
        AnoFabricacao = anoModelo;
    }
    public int GetAnoModelo()
    {
        return this.AnoFabricacao;
    }
    public void SetValorVenda(int valorVenda)
    {
        AnoFabricacao = valorVenda;
    }
    public double GetValorVenda()
    {
        return this.ValorVenda;
    }

    private bool ValidarAnoModelo(int ano)
    {
        if (ano == AnoFabricacao || ano == AnoFabricacao + 1)
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        CultureInfo culturaPtBr = new CultureInfo("pt-BR");
        string valorFormatado = ValorVenda.ToString("C", culturaPtBr);
        return "Marca: " + Marca + "\nModelo: " + Modelo + "\nAnoFabricacao: " + AnoFabricacao + "\nAnoModelo: " + AnoModelo + "\nValorVenda: " + valorFormatado + "\nMotor: " + Motor.ToString();
    }
}
    
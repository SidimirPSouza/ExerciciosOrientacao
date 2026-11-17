using System;
using System.Collections.Generic;
using System.Text;


public class Motor
{
    public Motor(string tipoCombustivel, int cc, string potencia)
    {
        TipoCombustivel = tipoCombustivel;
        CC = cc;
        Potencia = potencia;
    }
    public string TipoCombustivel;
    public int CC;
    public string Potencia;

    public override string ToString()
    {
        return $"Tipo de combustivel: {TipoCombustivel} \nCC: {CC} \nPotencia: {Potencia}";
    }

}

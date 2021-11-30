using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Funcionario
{
    public string nome;
    public float horasTrabalhadas;
    public float valorPorHora;

    public Funcionario(string nome, float horasTrabalhadas, float valorPorHora)
    {
        this.nome = nome;
        this.horasTrabalhadas = horasTrabalhadas;
        this.valorPorHora = valorPorHora;
    }

    public virtual float CalcularSalario()
    {
        return horasTrabalhadas * valorPorHora;
    }
}
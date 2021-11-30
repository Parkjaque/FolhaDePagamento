using System;
using System.Collections.Generic;

namespace FolhaDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Quantidade de funcionários: ");
            int qntFuncionarios = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qntFuncionarios; i++)
            {
                Console.Clear();

                Console.WriteLine("Nome: ");

                string nome = Console.ReadLine();

                if (nome == null) continue;

                Console.WriteLine("\nFuncionario terceirizado? ");
                string inputTerceirizado = Console.ReadLine();

                bool terceirizado = inputTerceirizado == "sim" || inputTerceirizado == "s";

                Console.WriteLine("\nHoras Trabalhadas: ");
                float horasTrabalhadas = float.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine("\nValor por hora: ");
                float valorPorHora = float.Parse(Console.ReadLine() ?? "0");

                Funcionario funcionario;

                if (terceirizado)
                {
                    Console.WriteLine("\nDespesas: ");
                    float despesas = float.Parse(Console.ReadLine() ?? "0");

                    funcionario = new Terceirizado(nome, horasTrabalhadas, valorPorHora, despesas);
                }
                else
                {
                    funcionario = new Funcionario(nome, horasTrabalhadas, valorPorHora);
                }

                funcionarios.Add(funcionario);
            }

            Console.Clear();

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario + ": " + funcionario.nome + " receberá R$" + funcionario.CalcularSalario());
            }
        }
    }
}

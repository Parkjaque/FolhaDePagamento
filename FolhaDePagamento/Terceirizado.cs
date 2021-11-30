using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
{
    class Terceirizado : Funcionario
    {
        public float despesas;

        public Terceirizado(string nome, float horasTrabalhadas, float valorPorHora, float despesas) : base(nome, horasTrabalhadas, valorPorHora)
        {
            this.despesas = despesas;
        }

        public override float CalcularSalario()
        {
            return base.CalcularSalario() + (despesas * 1.10f);
        }
    }
}
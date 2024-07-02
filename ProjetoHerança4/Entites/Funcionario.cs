using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHerança4.Entites
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario() 
        { 

        }

        public Funcionario(string nome, int horasTrabalhadas, double valorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return ValorHora * HorasTrabalhadas;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(" - R$ ");
            sb.Append(Pagamento().ToString());
            return sb.ToString();
        }
    }
}

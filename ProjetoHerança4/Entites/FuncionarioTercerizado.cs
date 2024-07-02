using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHerança4.Entites
{
    internal class FuncionarioTercerizado : Funcionario
    {
        public double DespezaAdicional {  get; set; }

        public FuncionarioTercerizado()
        {

        }
        public FuncionarioTercerizado(string nome, int horasTrabalhadas, double valorHora, double despezaAdicional)
            : base(nome, horasTrabalhadas, valorHora)
        {
            DespezaAdicional = despezaAdicional;
        }
        public  override double Pagamento()
        {
            
            return base.Pagamento() + 1.1 * DespezaAdicional;
           
        }
    }
}

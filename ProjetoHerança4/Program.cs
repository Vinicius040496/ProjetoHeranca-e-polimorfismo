using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoHerança4.Entites;

namespace ProjetoHerança4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.Write("Entre com numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Dados do funcionario #{0}: ",i);
                Console.Write("Funcionario tercerizado S/N: ");
                char Resp = char.Parse(Console.ReadLine());
                if (Resp == 'S' || Resp == 's')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Horas Trabalhadas: ");
                    int horasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Valor da despeza adicional tercerizado: ");
                    double despezaAdicional = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    FuncionarioTercerizado funcionario = new FuncionarioTercerizado(nome, horasTrabalhadas, valorHora, despezaAdicional);
                   list.Add(funcionario);
                    Console.WriteLine();
                }
                else if (Resp == 'N' || Resp == 'n')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Horas Trabalhadas: ");
                    int horasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Funcionario funcionario = new Funcionario(nome, horasTrabalhadas, valorHora);
                    funcionario.Pagamento().ToString("F2",CultureInfo.InvariantCulture);
                    list.Add(funcionario);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Dados invalidos, Tentre novamente!!");
                    Console.ReadLine();
                }

            }
            foreach (Funcionario f in list)
            {
                Console.WriteLine("Pagamentos: ");
                Console.WriteLine(f.Nome + " - R$ " + f.Pagamento().ToString("f2",CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}

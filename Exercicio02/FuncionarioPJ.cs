using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class FuncionarioPJ:Funcionario
    {
        public override double CalcularSalario()
        {
            Console.WriteLine("Digite o valor da hora:");
            double valorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            int qtdeHoras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Calculando salário PJ do funcionario {this.nome}");
            return valorHora*qtdeHoras; 
        }
    }
}

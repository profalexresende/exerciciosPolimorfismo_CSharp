using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class FuncionarioCLT:Funcionario
    {
        public override double CalcularSalario()
        {
            Console.WriteLine($"Calculando salário CLT do funcionario {this.nome}");
            return 3000; // Exemplo de salário fixo para CLT
        }
    }
}

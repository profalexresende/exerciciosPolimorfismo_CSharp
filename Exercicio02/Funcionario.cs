using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Funcionario
    {
        public string nome { get; set; }   

        public virtual double CalcularSalario()
        {
            Console.WriteLine("Salário base a ser calculado...");
            return 0;
        }
    }
}

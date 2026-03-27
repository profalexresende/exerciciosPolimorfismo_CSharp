using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class PagamentoCartao:Pagamento
    {
        public override void processarPagamento()
        {
            Console.WriteLine("Processando pagamento com cartão...");
        }
    }
}

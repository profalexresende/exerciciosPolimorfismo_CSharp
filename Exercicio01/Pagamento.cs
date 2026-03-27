using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Pagamento
    {
        public virtual void processarPagamento()
        {
            Console.WriteLine("Processando pagamento...");
        }
    }
}

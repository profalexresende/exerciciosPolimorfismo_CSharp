using Exercicio01;

Pagamento pagamento = new Pagamento();

while (true)
{
    Console.WriteLine("Escolha o método de pagamento:");
    Console.WriteLine("1 - Cartão");
    Console.WriteLine("2 - Boleto");
    Console.WriteLine("3 - Pix");
    Console.WriteLine("0 - Sair");
    string escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            pagamento = new PagamentoCartao();
            break;
        case "2":
            pagamento = new PagamentoBoleto();
            break;
        case "3":
            pagamento = new PagamentoPix();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            continue;
    }
    pagamento.processarPagamento();
}
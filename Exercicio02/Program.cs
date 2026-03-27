using Exercicio02;

Funcionario funcionario= new Funcionario();

while (true)
{
    Console.WriteLine("Digite o nome do funcionário:");
    string nome = Console.ReadLine();
    funcionario.nome = nome;
    Console.WriteLine("Digite o tipo de contratação (CLT ou PJ):");
    string tipoContratacao = Console.ReadLine();
    if (tipoContratacao.ToUpper() == "CLT")
    {
        funcionario = new FuncionarioCLT();
        
        double salarioCLT = funcionario.CalcularSalario();
        Console.WriteLine($"Salário CLT do funcionário {nome}: R${salarioCLT}");
    }
    else if (tipoContratacao.ToUpper() == "PJ")
    {
        funcionario = new FuncionarioPJ();
               
        double salarioPJ = funcionario.CalcularSalario();
        Console.WriteLine($"Salário PJ do funcionário {nome}: R${salarioPJ}");
    }
    else
    {
        Console.WriteLine("Tipo de contratação inválido. Por favor, digite CLT ou PJ.");
    }
    Console.WriteLine("Deseja calcular o salário de outro funcionário? (S/N)");
    string resposta = Console.ReadLine();
    if (resposta.ToUpper() != "S")
    {
        break;
    }
}
string opcao = "";
decimal saldoAtual=0;
List<decimal> transacoes = new List<decimal>();

do{
    Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção:");
    Console.WriteLine("1 - Adicionar Transação");
    Console.WriteLine("2 - Consultar extrato");
    Console.WriteLine("3 - Sair");

    int num;
    opcao = Console.ReadLine();    
    while (!(opcao == "1" || opcao == "2" || opcao == "3")){
        Console.WriteLine("Vamos tentar novamente, escolha um item do menu: ");
        opcao = Console.ReadLine();
    } 

    if(opcao=="1"){
        Console.WriteLine("Você escolheu 'Adicionar uma transação'! Informe o valor que deseja transacionar:");
        decimal valor;
        while (!decimal.TryParse(Console.ReadLine(), out valor)){
            Console.WriteLine("Vamos tentar novamente, digite um valor válido: ");
        }

        transacoes.Add(valor);
        saldoAtual += valor;
        Console.WriteLine("Transação efetuada com sucesso!");
        Console.WriteLine($"Pressione uma tecla para continuar...");
        Console.ReadLine();
    } else if(opcao=="2"){
        Console.WriteLine("Você escolheu 'Consultar o extrato'! Segue extrato abaixo para visualização:");
        foreach (decimal transacao in transacoes)
        {        
            Console.WriteLine(transacao);
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Saldo atual: R$ {saldoAtual}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Pressione uma tecla para continuar...");
        Console.ReadLine();
    }
} while(opcao != "3");
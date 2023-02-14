private double valorMinuto = 0.09;


string opcao = "";
List<Carro> carros = new List<Carro>();

do{
    Console.WriteLine("Bem-vindo ao estacionamento PARE AQUI! O que você deseja fazer?");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Marcar Entrada");
    Console.WriteLine("3 - Marcar Saída");
    Console.WriteLine("4 - Consultar histórico");
    Console.WriteLine("5 - Sair");

    int num;
    opcao = Console.ReadLine();    
    while (!(opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5")){
        Console.WriteLine("Vamos tentar novamente, escolha um item do menu: ");
        opcao = Console.ReadLine();
    } 

    if(opcao=="1"){    

    } else if(opcao=="2"){
        Console.WriteLine("Você escolheu 'Marcar Entrada'!:");
        
    } else if(opcao=="3"){
        Console.WriteLine("Você escolheu 'Marcar Saída'!:");
         
    } else if(opcao=="4"){
        Console.WriteLine("Você escolheu 'Consultar histórico'!:");        
    }

} while(opcao != "5");
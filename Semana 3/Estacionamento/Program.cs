using Estacionamento;
double valorMinuto = 0.09d;
string opcao = "";

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
        Console.WriteLine("Você escolheu 'Cadastrar Carro'! Precisamos coletar algumas informações:");                
        CadastrarCarro();

    } else if(opcao=="2"){
        Console.WriteLine("Você escolheu 'Marcar Entrada'!:");
        
    } else if(opcao=="3"){
        Console.WriteLine("Você escolheu 'Marcar Saída'!:");
         
    } else if(opcao=="4"){
        Console.WriteLine("Você escolheu 'Consultar histórico'!:");        
    }
    
} while(opcao != "5");


void CadastrarCarro(){
    Console.WriteLine("Informe a placa do veículo (contendo hifen):");
    string placa = Console.ReadLine();
    
    while (placa.Trim() == ""){
        Console.WriteLine("Vamos tentar novamente, digite um valor válido: ");
        placa = Console.ReadLine();
    }

    Console.WriteLine("Informe o modelo do veículo:");
    string modelo = Console.ReadLine();

    while (modelo.Trim() == ""){
        Console.WriteLine("Vamos tentar novamente, digite um valor válido: ");
        modelo = Console.ReadLine();
    }

    Console.WriteLine("Informe a marca do veículo:");
    string marca = Console.ReadLine();

    while (marca.Trim() == ""){
        Console.WriteLine("Vamos tentar novamente, digite um valor válido: ");
        marca = Console.ReadLine();
    }
    
    Carro carro = new Carro();
    carro.Placa = placa;
    carro.Modelo = modelo;
    carro.Marca = marca;

    Carro.carrosExistentes.Add(carro);
}
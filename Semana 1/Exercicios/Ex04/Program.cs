Console.WriteLine("Vamos verificar quanto você será cobrado do imposto de renda.");
Console.WriteLine("Qual o seu salário?");
decimal salario = Decimal.Parse(Console.ReadLine());
decimal retornoImpostoCobrado = 0;
int percentDesconto = 0;

if(salario > 900 && salario <= 1500)
    percentDesconto = 5;    
else if(salario > 1500 && salario <= 2500)
    percentDesconto = 10;    
else if(salario > 2500)
    percentDesconto = 20;
    
retornoImpostoCobrado = (salario * percentDesconto) / 100;

Console.WriteLine($"O valor do desconto é de {percentDesconto.ToString()}% e corresponde a R$ {retornoImpostoCobrado.ToString("N2")}");



Console.WriteLine("Informe um número inteiro");
int numero = int.Parse(Console.ReadLine());

for(int i=0;i<=10;i++)
    Console.WriteLine($"{numero.ToString()} x {i.ToString()} = {(numero * i).ToString()}");
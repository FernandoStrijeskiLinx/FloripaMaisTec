Console.WriteLine("Nota 1");
decimal nota1 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Nota 2");
decimal nota2 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Nota 3");
decimal nota3 = Decimal.Parse(Console.ReadLine());

decimal mediaFinal = (nota1 + nota2 + nota3) / 3;

if(mediaFinal >= 6)
    Console.WriteLine($"Aluno Aprovado com média {mediaFinal.ToString("N2")}");
else if(mediaFinal >= 5 && mediaFinal < 6)
    Console.WriteLine($"Aluno em Recuperação com média {mediaFinal.ToString("N2")}");
else
    Console.WriteLine($"Aluno Reprovado com média {mediaFinal.ToString("N2")}");
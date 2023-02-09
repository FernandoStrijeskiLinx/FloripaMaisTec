Console.WriteLine("Bem-vindo! Qual o nome do aluno?");
string alunoNome = Console.ReadLine();

Console.WriteLine("Quantas notas compõe a sua média? Digite um número inteiro: ");
int quantidadeNotas;
while ( !int.TryParse(Console.ReadLine(), out quantidadeNotas)){
    Console.WriteLine("Vamos tentar novamente! Quantas notas compõe a sua média? Digite um número inteiro: ");
}

decimal[] notas = new decimal[quantidadeNotas];


decimal nota;
for(int i=0;i<quantidadeNotas;i++){
    Console.WriteLine($"Digite a {(i+1).ToString()}a nota: (Digite um número válido)");
    while ( !Decimal.TryParse(Console.ReadLine(), out nota)){
        Console.WriteLine($"Vamos tentar novamente! Digite a {(i+1).ToString()}a nota: (Digite um número válido)");
    }
    notas[i] = nota;    
}

decimal somaDasNotas = 0;
for(int i=0;i<quantidadeNotas;i++){    
    somaDasNotas += notas[i];
}

decimal mediaFinal = somaDasNotas / quantidadeNotas;

Console.WriteLine($"Aluno: {alunoNome}");
for(int i=0;i<quantidadeNotas;i++){    
    Console.WriteLine($"N{(i+1).ToString()}: {notas[i].ToString("N2")}");
}

if(mediaFinal >= 6)
    Console.WriteLine($"Média: {mediaFinal.ToString("N2")} - Aprovado");
else if(mediaFinal >= 5 && mediaFinal < 6)
    Console.WriteLine($"Média: {mediaFinal.ToString("N2")} - Em recuperação");
else
    Console.WriteLine($"Média: {mediaFinal.ToString("N2")} - Reprovado");


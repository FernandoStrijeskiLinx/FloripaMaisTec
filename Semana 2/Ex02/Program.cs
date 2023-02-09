FichaInscricao ficha = new FichaInscricao(1, "Fernando Ricardo Strijeski", DateTime.Parse("07/04/1989"));

Console.WriteLine(ficha.DemonstraClasse());
string menorDeIdade = (ficha.MenorIdade == true ? "Sim" : "Não");
Console.WriteLine($"Menor de idade: {menorDeIdade}");

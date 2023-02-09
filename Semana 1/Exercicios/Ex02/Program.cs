Console.WriteLine("Qual a base do triangulo que deseja calcular?");
decimal base1 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Qual a altura do triangulo que deseja calcular?");
decimal altura1 = Decimal.Parse(Console.ReadLine());

decimal area = (base1 * altura1) / 2;

Console.WriteLine($"A área do triângulo é {area.ToString("N2")}");
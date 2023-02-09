Console.WriteLine("Lado 1");
decimal lado1 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Lado 2");
decimal lado2 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Lado 3");
decimal lado3 = Decimal.Parse(Console.ReadLine());


if(lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1){
    if(lado1==lado2 && lado1==lado3)
        Console.WriteLine("As medidas informadas formam um triângulo equilátero!");
    else if(lado1==lado2 || lado2==lado3 || lado3==lado1)
        Console.WriteLine("As medidas informadas formam um triângulo isósceles!");
    else if(lado1!=lado2 && lado2!=lado3 && lado3!=lado1)
        Console.WriteLine("As medidas informadas formam um triângulo escaleno!");
}else{
    Console.WriteLine("As medidas informadas não formam um triângulo válido!");
}
    

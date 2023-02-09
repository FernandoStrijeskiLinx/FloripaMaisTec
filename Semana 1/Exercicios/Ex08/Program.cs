int[] resultados = new int[21];
for(int n=0;n<21;n++){
    if(n==0)
        resultados[n] = 0;
    else if(n==1)
        resultados[n] = 1;
    else
        resultados[n] = (resultados[n-1]) + (resultados[n-2]);    

    if(resultados[n] > 0)
        Console.WriteLine($"{resultados[n].ToString()}, ");
}

//1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377…
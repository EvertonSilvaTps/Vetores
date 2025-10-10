int contImpar = 0, contPar = 0;
int[] todos = new int[6];
int[] pares = new int[6];
int[] impares = new int[6];

Console.WriteLine("Digite 6 números:\n");

for (int i = 0; i < 6; i++)
{
    Console.Write($"Numero {i+1}: ");
    todos[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < todos.Length; i++)
{
    if (pares[contPar] % 2 == 0)
        contPar++;
    else if (impares[contImpar] % 2 == 1)
        contImpar++;
}

Console.Write("\nPares: ");
for (int i = 0; i < contPar; i++)
{
    Console.Write(pares[i]);
}

Console.Write("\nImpares: ");
for (int i = 0; i < contPar; i++)
{
    Console.Write(impares[i]);

}

//Console.WriteLine($"\nAo todo, foram {contPar} pares e {contImpar} ímpares.");

Console.ReadKey();

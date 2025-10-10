int contImpar = 0, contPar = 0;
int[] todos = new int[6];

Console.WriteLine("Digite 6 números:\n");

for (int i = 0; i < 6; i++)
{
    Console.Write($"Numero {i+1}: ");
    todos[i] = int.Parse(Console.ReadLine());
    if (todos[i] % 2 == 0)
        contPar++;
    else
        contImpar++;
}

int[] pares = new int[contPar];
int[] impares = new int[contImpar];

for (int i = 0; i < todos.Length; i++)
{
    if (todos[i] % 2 == 0)
        pares[i] = todos[i];
    else
        impares[i] = todos[i];
}

Console.WriteLine($"\nAo todo, foram {contPar} pares e {contImpar} ímpares.");

Console.ReadKey();

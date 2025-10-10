int NumberBusca, Cont = 0;
int[] numeros = new int[10];

Console.WriteLine("Digite 10 números inteiros: \n");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nInforme um número de busca: ");
NumberBusca = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == NumberBusca)
    {
        Cont++;
    }
}
if (Cont > 1)
    Console.WriteLine($"\nO número {NumberBusca} apareceu {Cont} vezes");
else
    Console.WriteLine($"\nO número {NumberBusca} apareceu apenas {Cont} vez");
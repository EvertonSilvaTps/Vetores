int soma = 0;
int[] numeros = new int[5];

Console.WriteLine("Digite 5 números inteiros pra soma: ");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Número{i+1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
    soma += numeros[i];
}

Console.WriteLine($"A soma dos números é: {soma}");
Console.ReadKey();
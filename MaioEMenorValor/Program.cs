double[] numeros = new double[10];
double maior = 0;

Console.WriteLine("Digite 10 números:\n");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Número {i+1}: ");
    numeros[i] = double.Parse(Console.ReadLine());
    if (maior < numeros[i])
        maior = numeros[i];
}
Console.WriteLine($"\nO maior número é {maior}");
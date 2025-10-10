int[] numeros = new int [5];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Random.Shared.Next(1, 100);
}

int contador = 0;

do
{
    Console.WriteLine(numeros[contador]);
    contador++;
} while (contador < numeros.Length);
Console.ReadKey();

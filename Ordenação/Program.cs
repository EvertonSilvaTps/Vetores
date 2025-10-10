int[] vetorOriginal = new int[10];
int[] vetorOrdenado = new int[10];
int aux;


Console.Write("Ordem aleátoria: ");
for (int i = 0; i < vetorOriginal.Length; i++)
{
    vetorOriginal[i] = Random.Shared.Next(0, 50);
    Console.Write(vetorOriginal[i] + " ");
    vetorOrdenado[i] = vetorOriginal[i];
}

Console.Write("\n\nOrdem ordenada: ");
for (int referencia = 0; referencia < vetorOrdenado.Length -1; referencia++)
{
    for (int comparacao = referencia + 1; comparacao < vetorOrdenado.Length; comparacao++)
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];  // Aux recebe a referencia, que será a referencia +1 no próximo laço (o primeiro)
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
        }
    }
}
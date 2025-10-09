int i = 0, tamanho = 0;

Console.Write("Informe o tamanho do vetor: ");
tamanho = int.Parse(Console.ReadLine());              // coleta de um número inteiro pelo usuário

Console.WriteLine(); // Pular linha


int[] numeros = new int[tamanho]; // Criação do vetor 'numeros' recebendo como qtdd a leitura do usuário (variável>tamanho)


//  <<< [1] >>>
//--------------------------------------------------------------------------------------------------------------------------------------
while (i < tamanho)
{
    numeros[i] = Random.Shared.Next(1, 100);  //Gerar números aleátorios de acordo com a qtdd informada pelo usuário, sendo do intervalo 1 a 100
    i++;
}
//--------------------------------------------------------------------------------------------------------------------------------------


//  <<< [2] >>>
//--------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Vetor inteiro");
for (i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");  // Impressão do vetor inteiro
}

Console.WriteLine("\n\n"); // Pular linha
//--------------------------------------------------------------------------------------------------------------------------------------


//  <<< [3] >>>
//--------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Primeira metade");
for  (i = 0; i < (numeros.Length/2); i++)
{
    Console.Write(numeros[i] + " ");  // Impressão da primeira metade do vetor
}

Console.WriteLine("\n\n"); // Pular linha
//--------------------------------------------------------------------------------------------------------------------------------------


//  <<< [4] >>>
//--------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Segunda metade");
for (i = (numeros.Length/2); i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");    // Impressão da segunda metade do vetor
}

Console.WriteLine("\n\n"); // Pular linha
//--------------------------------------------------------------------------------------------------------------------------------------


//  <<< [5] >>>
//--------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Segunda metade ao contrário");
for (i = numeros.Length -1; (i >= numeros.Length/2); i--)
{
    Console.Write(numeros[i] + " ");    // Impressão da segunda metade do vetor ao contrário
}
//--------------------------------------------------------------------------------------------------------------------------------------


Console.ReadKey();
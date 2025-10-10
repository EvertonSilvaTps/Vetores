double[] PrecoProduto = new double[5];
double[] PrecoProdutoAtualizado = new double[5];

Console.WriteLine("Digite o preço de 5 produtos:\n");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Produto {i+1}: R$ ");
    PrecoProduto[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < PrecoProduto.Length; i++)
{
    PrecoProdutoAtualizado[i] = PrecoProduto[i] - (PrecoProduto[i] / 10);
    Console.WriteLine($"\nProduto {i+1}:" +
                      $"\nValor original > R$ {PrecoProduto[i]:F2}" +
                      $"\nValor com 10% desc. > R$ {PrecoProdutoAtualizado[i]:F2}");
}

Console.ReadKey();
using System;

namespace SorteioPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numerosSorteados = new int[15];

            Console.WriteLine("15 Pessoas Sorteadas:");
            for (int i = 0; i < 15; i++)
            {
                int numeroSorteado = random.Next(1, 101); // Gera números aleatórios de 1 a 100
                numerosSorteados[i] = numeroSorteado;
                Console.WriteLine($"Pessoa {i + 1}: {numeroSorteado}");
            }

            // Você pode usar o array 'numerosSorteados' conforme necessário no seu aplicativo.
        }
    }
}

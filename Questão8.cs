namespace Lista5
{
    internal class Questao8
    {
        public static void Rodar()
        {
            Console.WriteLine("Questão 8: ");

            int [,] matriz = new int [4, 4];
            Matriz(matriz);
            diagonalPrincipal(matriz);
            Console.WriteLine("A soma dos elementos abaixo da diagonal principal é: " + Soma(matriz));

        }
        static void Matriz(int[,] m)
        {
            //sorteando e definindo os números da matriz
            Random r = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = r.Next(0, 100);
                }
            }
        }

        static void diagonalPrincipal(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"Elemento[{i}] da diagonal = {m[i, j]}"); //escrevendo os elementos da diagonal principal da matriz
                    }
                }
            }
        }

        static int Soma(int[,] m)
        {
            int soma = 0;
            for (int i = 1; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    soma += m[i, j]; //somando os números que estão abaixo da diagonal principal da matriz
                }
            }
            return soma;
        }
    }
}
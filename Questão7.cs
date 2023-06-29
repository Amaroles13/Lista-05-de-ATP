namespace Lista5
{
    internal class Questao7
    {
        public static void Rodar()
        {
            Console.WriteLine("Questão 7:");
            
            int linha = 5, coluna = 5;
            int [,] matriz = new int[linha, coluna];

            Matriz(matriz);
            Console.WriteLine("Soma da Linha 4 da matriz: " + linha4(matriz).ToString("D3"));
            Console.WriteLine("Soma da Coluna 2 da matriz: " + coluna2(matriz).ToString("D3"));
            Console.WriteLine("Soma da Diagonal principal da matriz: " + diagonalPrincipal(matriz).ToString("D3"));
            Console.WriteLine("Soma da Diagonal Secundária da matriz: " + diagonalSecundaria(matriz).ToString("D3"));
            Console.WriteLine("Soma de todos os itens da matriz: " + somaTotal(matriz).ToString("D3"));
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

        static int linha4(int[,] m)
        {
            //somando os números da linha 4 da matriz
            int somaLinha = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    somaLinha += m[3, j]; //a quarta linha da matriz é representada pela posição 3
                }
            }
            return somaLinha;
        }
        static int coluna2(int[,] m)
        {
            //somando os números da coluna 2 da matriz
            int somaColuna = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    somaColuna += m[i, 1]; //a segunda coluna da matriz é representada pela posição 1
                }
            }
            return somaColuna;
        }
        static int diagonalPrincipal(int[,] m)
        {
            //somando os números da diagonal principal da matriz
            int somaDP = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        somaDP += m[i, j];
                    }
                }
            }
            return somaDP;
        }
        static int diagonalSecundaria(int[,] m)
        {
            //somando os números da diagonal secundária da matriz
            int somaDS = 0;
            int n = m.GetLength(0) - 1;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i + j == n)
                        somaDS += m[i, j];
                }
            }
            return somaDS;
        }

        static int somaTotal(int[,] m)
        {
            //somando todos os números da matriz
            int somaTotal = 0;
            for (int i = 0; i < m.GetLength(0); i++)            
            {
                for (int j = 0; j <m.GetLength(1); j++)
                {
                    somaTotal += m[i, j];
                }
            }
            return somaTotal;
        }
    }
}
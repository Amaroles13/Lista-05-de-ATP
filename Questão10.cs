namespace Lista5
{
    internal class Questao10
    {
        public static void Rodar()
        {
            Console.WriteLine("Questão 10: ");

            int[,] matriz = new int[10, 10];
            preencherMatriz(matriz);
            //imprimindo matriz original (sem alterações)
            Console.WriteLine("\nMatriz original:");
            ImprimirMatriz(matriz);
            
            //imprimir matriz com a linha 2 trocada pela linha 8
            trocaLinha(matriz);
            Console.WriteLine("\nMatriz com linha 2 trocada pela linha 8: ");
            ImprimirMatriz(matriz);

            //imprimir matriz com a coluna 4 trocada pela coluna 10
            trocaColuna(matriz);
            Console.WriteLine("\nMatriz com coluna 4 trocada pela coluna 10: ");
            ImprimirMatriz(matriz);

            //imprimir matriz com a diagonal principal trocada pela diagonal secundária
            trocaDiagonais(matriz);
            Console.WriteLine("\nMatriz com diagonal principal trocada pela diagonal secundária: ");
            ImprimirMatriz(matriz);

            //imprimir matriz com linha 5 trocada pela coluna 10
            trocarLinhaColuna(matriz);
            Console.WriteLine("\nMatriz com linha 5 trocada pela coluna 10: ");
            ImprimirMatriz(matriz);
        }

        static void preencherMatriz(int[,] m)
        {
            Random r = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = r.Next(0, 50);
                }
            }
        }

        static void trocaLinha(int[,] m)
        {
            int aux = 0;
            for (int j = 0; j < m.GetLength(1); j++)
            {
                aux = m[1, j]; //variável auxiliar recebe a linha 2 9que está na posição 1
                m[1, j] = m[7, j]; //linha 2 recebe a linha 8 (que está na posição 7)
                m[7, j] = aux; //linha 8 recebe a variável auxiliar (antiga linha 2)
            }
        }
        static void trocaColuna(int[,] m)
        {
            int aux = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                aux = m[i, 3]; //variável auxiliar recebe a coluna 4 que está na posição 3
                m[i, 3] = m[i, 9]; //coluna  4 recebe a coluna 10 (que está na posição 8)
                m[i, 9] = aux; //coluna 10 recebe a variável auxiliar (antiga coluna 4)
            }
        }
        static void trocaDiagonais(int[,] m)
        {
            int aux = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                aux = m[i, i]; //variável auxiliar recebe a diagonal principal
                m[i, i] = m[i, m.GetLength(0) - 1 - i]; //diagonal principal recebe a diagonal secundária
                m[i, m.GetLength(0) - 1 - i] = aux; //diagonal secundária recebe a variável auxiliar (antiga diagonal principal)
            }
        }

        static void trocarLinhaColuna(int[,] m)
        {
            int [] aux = new int [10];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                    aux[i] = m[i, 9]; //variável auxiliar recebe a linha 5 da matriz (posição 4)
            
            }
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[4, j] = aux[j]; //linha 10 da matriz recebe a variável auxiliar (antiga linha 5)
            }
            
        }
        static void ImprimirMatriz(int[,] m)
        {
            //método de imprimir a matriz
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
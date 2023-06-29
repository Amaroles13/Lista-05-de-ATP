namespace Lista5
{
    internal class Questao9
    {
        public static void Rodar()
        {
            Console.WriteLine("Questão 9:");

            //defininfo o tamanho das matrizes A e B
            int[,] mA = new int[4, 6];
            int[,] mB = new int[4, 6];
            Matrizes(mA, mB);
            //definindo o conteúdo das matrizes S (soma1) e D (diferença)
            int[,] matrizS = somaMatrizes(mA, mB);
            int[,] matrizD = diferencaMatrizes(mA, mB);
            //acionando o método "ImprimirMatriz"
            Console.WriteLine("\nMatriz S (soma de A e B):");
            ImprimirMatriz(matrizS);
            Console.WriteLine("\nMatriz D (diferença de A e B):");
            ImprimirMatriz(matrizD);
        }

        static void Matrizes(int[,] mA, int[,] mB)
        {
            //sorteando e definindo os números da matriz A
            Random r = new Random();
            for (int i = 0; i < mA.GetLength(0); i++)
            {
                for (int j = 0; j < mA.GetLength(1); j++)
                {
                    mA[i, j] = r.Next(0, 50);
                }
            }
            //sorteando e definindo os números da matriz B
            Random rd = new Random();
            for (int i = 0; i < mB.GetLength(0); i++)
            {
                for (int j = 0; j < mB.GetLength(1); j++)
                {
                    mB[i, j] = r.Next(0, 50);
                }
            }
        }

        static int[,] somaMatrizes(int[,] mA, int[,] mB)
        {
            int[,] S = new int[4, 6];
            //realizando a soma entre as matrizes A e B
            for (int i = 0; i < S.GetLength(0); i++)
            {
                for (int j = 0; j < S.GetLength(1); j++)
                {
                    S[i, j] = mA[i, j] + mB[i, j];
                }
            }
            return S;
        }
        static int[,] diferencaMatrizes(int[,] mA, int[,] mB)
        {
            int[,] D = new int[4, 6];
            //realizando a subtração da matriz A pela matriz B
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    D[i, j] = mA[i, j] - mB[i, j];
                }
            }
            return D;
        }
        //método que imprime as matrizes finais (S e D)
        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
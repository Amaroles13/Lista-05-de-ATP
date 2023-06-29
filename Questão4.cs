namespace Lista5 
{
    internal class Questao4
    {
        public static void Rodar()
        { 
            Console.WriteLine("Questão 4:");
            //determinando o tamanho dos vetores x e y
            int [] vetorX = new int [10];
            int [] vetorY = new int [10];
            //acionando o método "Vetores"
            Vetores(vetorX, vetorY);
            //atribuíndo o vetor concebido no método "mesclaVetores" a um novo vetor, para que esse possa ser relacionado ao método "exibeVetor"
            int [] vetorIntercalado = mesclaVetores(vetorX, vetorY);
            exibeVetor(vetorIntercalado);
            Console.ReadLine();
            
            }

        static void Vetores(int [] vetorX, int [] vetorY){
            //definindo valores para cada posição dos vetores X e Y
            for (int i = 0; i < vetorX.Length; i++)
            {
                Console.WriteLine($"Digite um valor para a posição {i} no vetor X: ");
                vetorX[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite um valor para a posição {i} no vetor Y: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }
        }

        static int[] mesclaVetores(int [] vetorX, int [] vetorY){
            int [] vetorFinal = new int [vetorX.Length + vetorY.Length];
            int posicao = 0;
            //realizando a intercalação entre os vetores X e Y de acordo com a posição (par e ímpar, respectivamente)
            for (int i = 0; i < vetorX.Length; i++)
            {
                vetorFinal[posicao] = vetorX[i]; //atribui o valor na posição i do vetor X a alguma posição par no vetor final
                posicao++; //pula para a próxima posição no vetor final, à qual será atribuído um número do vetor Y
                vetorFinal[posicao] = vetorY[i]; //atribui o valor na posição i do vetor Y a alguma posição ímpar no vetor final
                posicao++; //pula para a próxima posição no vetor final, à qual será atribuído um número do vetor X
            }
            return vetorFinal;
        }

        static void exibeVetor(int [] vetor){
            Console.WriteLine("\nConteúdo do vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Vetor[{i}] = {vetor[i]}"); //mostra a posição e o valor atribuido á posição no vetor final (mesclado)
            }
        }
    }
}
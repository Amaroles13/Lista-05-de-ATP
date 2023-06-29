namespace Lista5
{
    internal class Questao3
    {
        public static void Rodar()
        { 
            Console.WriteLine("Questão 3:");
            int[] vetorFinal = new int[10];
            preencheVetor(vetorFinal);

            int[] vetorNegativo = copiaNegativos(vetorFinal);
            exibeVetor(vetorNegativo);

            Console.ReadLine();
        }

        static void preencheVetor (int [] vetor){
            Console.WriteLine("Preenchendo o vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
              Console.WriteLine($"Digite um valor para a posição {i}: ");
              vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        static int[] copiaNegativos(int[] vetor){
            int cont = 0;
            //contando a quantidade de números negativos no vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0){
                    cont++;
                }
            }
            //copiando os números negativos para um novo vetor
            int[] newVetor = new int[cont];
            int contNeg = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] < 0){
                    //atribuíndo os valores negativos do vetor anterior ao novo vetor
                    newVetor[contNeg] = vetor[i];
                    contNeg++;
                }
            }
            return newVetor;
        }
        //exibindo o conteúdo do novo vetor formado (apenas de números negativos)
        static void exibeVetor(int[] vetor){
            Console.WriteLine("Conteúdo do novo vetor: ");
            for (int i = 0; i < vetor.Length; i++){
                Console.WriteLine($"Vetor[{i}] = {vetor[i]}");
            }
        }
    }
}
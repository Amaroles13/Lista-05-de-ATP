namespace Lista5
{
    internal class Questao5
    {
        bool encontrei;
        public static void Rodar()
        {
            Console.WriteLine("Questão 5:");
            int num;
            int[] vet = SorteiaNumeros();
            while (true)
            {
                Console.WriteLine("Tente adivinhar o número sorteado!");
                num = int.Parse(Console.ReadLine());

                if (Tentativa(vet, num) == true)
                {
                    //adivinhou o número
                    Console.WriteLine("Número encontrado!");
                    break;
                }
                else
                {
                    Console.WriteLine("Número não encntrado. Tente novamente!");
                }
            }
        }
        static int[] SorteiaNumeros()
        {
            Random random = new Random();
            int[] numSorteados = new int[3];
           
            for (int i = 0; i < numSorteados.Length; i++)
            {
                numSorteados[i] = random.Next(10, 51);
            }

            return numSorteados;
        }

        static bool Tentativa(int[] numeros, int numeroLido)
        {
            foreach (int item in numeros)
            {
                //verificando se a pessoa adivinhou ou não o número sorteado
                if (numeroLido == item)
                {
                    return true;
                }
            }
            return false;
        }

    }

}
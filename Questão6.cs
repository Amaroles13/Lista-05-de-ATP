namespace Lista5
{
    internal class Questao6
    {
        public static void Rodar()
        {
            Console.WriteLine("Questão 6:");
            
            int [] vetorTemp = new int [31];
            int [] vetorTemperaturas = Temperaturas(vetorTemp);
            calculaDados(vetorTemperaturas);
            Console.ReadLine();
        }

        static int[] Temperaturas(int[] vetorTemp)
        {
            //sorteio das temperaturas do mês de outubro (que ficaram entre 15 e 40 graus)
            Random rd = new Random();
            for (int i = 0; i < vetorTemp.Length; i++) //31 pois outubro possui 31 dias
            {
                vetorTemp[i] = rd.Next(15, 41);
                Console.WriteLine($"Dia[{i + 1}] = {vetorTemp[i]}"); //o dia está classificado como "i+1" pois a posição i do primeiro dia seria 0, mas o dia é 1
            }
            return vetorTemp;
        }

        static void calculaDados(int[] vetor)
        {
            int menor = vetor[0];
            int maior = vetor[0];
            double mediaTemp = 0;
            int dias = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                //definindo a menor temperatura
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
                //definindo a maior temperatura
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                //cálculo da média de temperaturas
                mediaTemp += vetor[i] / 31;
                //dias em que a temperatura foi inferior à temperatura média
                if (vetor[i] <  mediaTemp)
                {
                    dias++;
                }
            }
            Console.WriteLine($"A menor temperatura foi: {menor}");
            Console.WriteLine($"A maior temperatura foi: {maior}");
            Console.WriteLine($"A temperatura média foi: {mediaTemp}");
            Console.WriteLine($"A quantidade de dias em que a temperatura foi inferior à média é: {dias}");


        }
    }
}
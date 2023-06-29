namespace Lista5
{
    internal class Questao2
    {
        public static void Rodar()
        {
            Console.WriteLine("Questão 2:");
            Console.WriteLine("Quantos alunos tem na escola?");
            int n = int.Parse(Console.ReadLine());
            int[] notasAlunos = new int[n];

            notasAlunos = vetNotas(notasAlunos);

            calculaMedia(notasAlunos);
        }

        static int[] vetNotas(int[] Notas)
        {
            //vetor que recebe as notas de dez alunos
            Random rd = new Random();
            for (int i = 0; i < Notas.Length; i++)
            {
                Notas[i] = rd.Next(0, 101);
            }
            return Notas;
        }

        static void calculaMedia(int[] Notas)
        {
            //vetor que calcula a média da turma e conta quantos alunos ficaram acima dessa média
            double media, somatorio = 0;
            int cont = 0;
            //média
            foreach (int item in Notas)
            {
                somatorio += item;
            }
            media = somatorio / Notas.Length;
            //acima da média
            for (int i = 0; i < Notas.Length; i++)
            {
                if (Notas[i] > media)
                    cont++;
            }

            Console.WriteLine($"A média turma é: {media}");
            Console.WriteLine($"O total de alunos acima da média é: {cont}");

        }
    }
}
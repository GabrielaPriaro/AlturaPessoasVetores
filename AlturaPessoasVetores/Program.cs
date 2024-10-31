////obs: Utilizando Vetores
//Problema "alturas"
//Fazer um programa para ler nome, idade e altura de N pessoas, conforme exemplo. Depois, mostrar na
//tela a altura média das pessoas, e mostrar também a porcentagem de pessoas com menos de 16 anos,
//bem como os nomes dessas pessoas caso houver. 

using System.Globalization;

namespace AlturaPessoasVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, contMenorDezesseis;
            double somaAltura, mediaAltura, percMenorDezesseis;
            string nomesMenorDezesseis;
            const int menorDezesseis = 16;

            somaAltura = 0;
            contMenorDezesseis = 0;
            nomesMenorDezesseis = "";

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados da {i + 1}a pessoa:");

                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < n; i++)
            {
                somaAltura = somaAltura + altura[i];
            }

            mediaAltura = somaAltura / n;

            for (int i = 0; i < n; i++)
            {
                if (idade[i] < menorDezesseis)
                {
                    contMenorDezesseis++;
                    nomesMenorDezesseis = nomesMenorDezesseis == "" ? nome[i] : nomesMenorDezesseis + "\n\r" + nome[i];
                }
            }

            percMenorDezesseis = (double)contMenorDezesseis / n * 100;

            Console.WriteLine();
            Console.WriteLine($"Altura média: {mediaAltura.ToString("F2", CI)}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {percMenorDezesseis.ToString("F1", CI)}%");
            Console.WriteLine(nomesMenorDezesseis);
        }
    }
}

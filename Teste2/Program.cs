using System;


namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;

            int numeroDigitado = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < numeroDigitado; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
               
                if (fibonacci == numeroDigitado)
                {
                    Console.WriteLine("O número {0} informado pertence a sequencia fibonacci", numeroDigitado);
                    break;
                }else if (fibonacci > numeroDigitado) 
                {
                    Console.WriteLine("O número {0} informado não pertence a sequencia fibonacci", numeroDigitado);
                    break;
                }
            }



        }


    }
}

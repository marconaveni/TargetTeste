using System;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int indice = 13, soma = 0, k = 0;
            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine(soma);
        }
    }
}

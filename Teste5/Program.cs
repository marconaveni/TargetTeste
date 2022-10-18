using System;

namespace Teste5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string texto = Console.ReadLine();
            string textoInvertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido = textoInvertido + texto[i];
            }
            Console.WriteLine(textoInvertido);
        }
    }
}

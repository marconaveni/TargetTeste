using System;
using System.Reflection;

namespace Teste4
{
    internal class Program
    {
        enum Estado
        {
            SP,            //SP – R$67.836,43
            RJ,            //RJ – R$36.678,66
            MG,            //MG – R$29.229,88
            ES,            //ES – R$27.165,48
            Outros         //Outros – R$19.849,53
        }
        static void Main(string[] args)
        {

            /*                      sp        rj       mg          es       outros  */
            double[] estados = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
            double total = 0;

            for (int i = 0; i < estados.Length; i++)
            {
                total = total + estados[i];
            }

            for (int i = 0; i < estados.Length; i++)
            {
                Estado estado = (Estado)i;
                double percentualTotal = (estados[i] / total) * 100;
                Console.WriteLine("{0:F2}% em {1}", percentualTotal, estado);
            }

        }
    }
}

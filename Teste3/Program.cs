using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

namespace Teste3
{
    internal class Program
    {

        public class Fatura
        {
            public string dia { get; set; }
            public double valor { get; set; }         
        }

        public class Faturas
        {
            public List<Fatura> dados { get; set; }
        }

        public class Faturamento
        {
            public string dadosFatura { get; set; }
            public double menorValor { get; set; }
            public double maiorValor { get; set; }
            public double totalValor { get; set; }
            public double mediaMensal { get; set; }
            public int diasFaturados { get; set; }
            public int diasMaiorQueMedia { get; set; }

        }

        static void Main(string[] args)
        {
			var path = File.ReadAllText(@".\dados.json");

            Faturamento faturamento = new Faturamento();
            faturamento.dadosFatura = @"{""dados"": " + path + @" }";
            faturamento.menorValor = 0;
            faturamento.maiorValor = 0;

            var deserialize = (Faturas)JsonConvert.DeserializeObject(faturamento.dadosFatura, typeof(Faturas));

            foreach (var data in deserialize.dados)
            {     
                if(data.valor > 0)
                {
                    faturamento.diasFaturados++;
                    faturamento.totalValor = faturamento.totalValor + data.valor;

                    if (data.valor > faturamento.maiorValor)
                    {
                        faturamento.maiorValor = data.valor;
                    }
                    if (data.valor < faturamento.menorValor || faturamento.menorValor == 0)
                    {
                        faturamento.menorValor = data.valor;
                    }
                   
                }
            }

            faturamento.mediaMensal = faturamento.totalValor / faturamento.diasFaturados;

            foreach (var data in deserialize.dados)
            {
                if(data.valor > faturamento.mediaMensal) 
                {
                    faturamento.diasMaiorQueMedia++;
                }
            }

            Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês: {0:F2}", faturamento.menorValor);
            Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês: {0:F2}", faturamento.maiorValor);
            Console.WriteLine("Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: {0:D}", faturamento.diasMaiorQueMedia);


        }
    }
}

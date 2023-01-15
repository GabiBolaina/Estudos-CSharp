using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            raio = 5.5;
            // PI = 3.1415; dá erro 
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);
            Console.WriteLine("Área é " + area + 1000); // concatena
            Console.WriteLine("Área é " + (area + 1000)); // soma, colocou um () pra somar pq começou com concatenação

            //Tipos internos 

            //Boleano
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo); 
            
            //Inteiros
            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; //byte com sinal 
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Tipo mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt); //Tem sinal + e -

            uint populacaoBrasileira = 200_600_000; //Não tem sinal -- pode usar _ pra separar o número pra ficar mais facil ler  --- u de unsign
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            //Reais ou pontos flutuantes
            float precoComputador = 1299.99f; //float precisa do f no final
            Console.WriteLine("Preco Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância Entre Estrelas " + distanciaEntreEstrelas);

            //Letras
            char letra = 'b'; // com 1 letra pode usar aspas simples, com +1 não
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine(texto);

        }
    }
}

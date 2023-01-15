using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Leonardo"; // tipico de linguagens sem tipos fortes
            Console.WriteLine(nome);
            // nome = 123; da erro, o C# fez a inferencia do tipo e não deixa trocar

            //var idade; não pode criar pq pra inferencia precisa criar com valor
            // pode criar com int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a; //declaração da variavel
            a = 3; //atribuição ou inicialização
            int b = 2; // declarou e inicializou

            Console.WriteLine(a + b);
        }
    }
}

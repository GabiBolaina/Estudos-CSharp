using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.WriteLine("Digite a nota do aluno: ");

            //string entrada = Console.ReadLine();
            //Double.TryParse(entrada, out double nota);

            Double.TryParse(Console.ReadLine(), out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de honra!");
            } else if (nota >= 7.0) {  //Não precisa do && <9.0 pq se fosse >=9.0 já parava no de cima, nem continuava 
                Console.WriteLine("aprovado!");
            } else if (nota >= 5.0) {
                Console.WriteLine("Recuperação");
            } else {
                Console.WriteLine("Te vejo na proxima...");
            }

            Console.WriteLine("Fim!");
        }
    }
}

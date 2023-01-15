using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            //Console.WriteLine("Digite a nota do aluno: ");
            //entrada = Console.ReadLine();
            //Double.TryParse(entrada, out double nota);

            Console.WriteLine("Digite a nota do aluno: ");
            Double.TryParse(Console.ReadLine(), out double nota); 

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s")
            //    bomComportamento = true;
            // outra forma
            //bomComportamento = entrada == "S" || entrada == "s";


            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) {    // se colocar ; entre ){ dá erro no código
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}

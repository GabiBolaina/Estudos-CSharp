using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {

            //int i = 1;
            //while(i <= 10) {
            //    Console.WriteLine($"O valor de i é {i}");
            //    i++;
            //}
            //Usando o for fica melhor
            //for (int i = 1; i <= 10; i++) {   //pode declarar todos os for com i, não tem problema pq a variavel só existe no for
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;                
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Média da turma: {0}", media);

            //exemplo de for infinito, que não deve ser usado, tem que usar o while 
            //for(; media > 0;) { }
            // pode decrementar o for tbm
            // for(int i = tamanhoTurma; i >= 1; i--)
        }
    }
}

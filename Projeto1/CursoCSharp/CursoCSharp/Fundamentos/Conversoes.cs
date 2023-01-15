using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro; //Conversão implicita, não perde informação
            Console.WriteLine(quebrado);

            double nota = 9.7;
            //int notaTruncada = nota; da erro
            int notaTruncada = (int) nota; //Conversão explicita, corre risco de perder informção
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            //Conversão é um CAST - conversão explicita

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            //Forma segura de conversão, se der erro converte pra 0
            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado 1: {0}", numero);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); //Declarou dentro do read o numero2
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}

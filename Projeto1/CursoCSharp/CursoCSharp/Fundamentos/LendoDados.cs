using System;
using System.Globalization; //unificar simbolos das máquinas (. e , como separador de casas decimais por exemplo)

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); //por padrão ele lé como string, ai se for outro tipo tem que converter

            Console.WriteLine("Qual é o seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //sempre vai usar ponto como separador de casas decimais

            Console.WriteLine($"{nome} {idade} {salario}");
        }
    }
}

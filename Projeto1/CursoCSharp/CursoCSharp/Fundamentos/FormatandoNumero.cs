using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //F1 -- formatar com uma casa decimal, arredonda
            Console.WriteLine(valor.ToString("C")); //Currence, uma moeda
            Console.WriteLine(valor.ToString("P")); //Percentual
            Console.WriteLine(valor.ToString("#.##")); //2 casas decimais, podia ter colocado F2

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura)); //Moeda sem casa decimal

            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura2)); //Moeda sem casa decimal

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //Completa com zeros antes do número > 0000000256
        }
    }
}

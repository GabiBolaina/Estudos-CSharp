using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //inverte o sinal
            Console.WriteLine(!booleano); //negação lógica, ou seja, inverte true p/ false e vice-versa

            numero1++; //incremento  - versão pós fixada
            Console.WriteLine(numero1);

            --numero1; //decremento; - versão pre fixada
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); //numero1 só sera incrementado depois da comparação e o numero2 antes da comparação
            //Vai dar true
            Console.WriteLine($"{numero1} {numero2}");
            //Vai mostrar 3 e 2, apesar de ter dado true em cima

            Console.WriteLine(++numero1 == --numero2);
            //Agora deu false
        }
    }
}

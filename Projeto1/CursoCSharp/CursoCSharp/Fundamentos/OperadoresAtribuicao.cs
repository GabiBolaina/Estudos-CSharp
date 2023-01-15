using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; //num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a; //nesse caso é copia literal, recebe 1, não é uma referencia

            a++; // a = a + 1;  //é uma atribuição
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}"); // output 2 e 0 pq foi copia por valor não por referencia

            // Não se preocupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome); //vai mostrar Maria, pois foi copia por referencia, os dois ocupam o msm espaço de mémoria, vão ter o mesmo valor sempre

            c.nome = "Gabi";

            Console.WriteLine($"c: {c.nome} d: {d.nome} c=d {c==d}"); 

            //São dois comportamentos de atribuição diferente, referencia e copia
        }
    }
}

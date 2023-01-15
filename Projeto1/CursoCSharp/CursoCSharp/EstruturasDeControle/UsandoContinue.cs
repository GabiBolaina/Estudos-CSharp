using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue; //pula pra próxima repetição, volta pro for
                }
                Console.Write(i + " ");
            }

            // outra maneira de mostrar os números pares
            //for (int i = 2; i <= intervalo; i+=2) { 
            //    Console.Write(i + " "); 
            //}
        }
    }
}

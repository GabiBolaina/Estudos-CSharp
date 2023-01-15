using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    /// <summary>
    /// 
    /// </summary>
    class Comentarios {
        /// <summary>
        /// Se tiver o int a lá em baixo, já cria falando dele
        /// </summary>
        /// <param name="a"></param>
        public static void Executar() {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            // são as /// barras lá em cima
            Console.WriteLine("O C# tem o XML Comments");
            /* 
             * Esse é um comenttário 
             * de múltiplas linhas...
             o * no começo é opcional
             */
        }
    }
}

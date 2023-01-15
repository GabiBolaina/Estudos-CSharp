using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            // . + ctrl + espaço aparece as opções de funções

            Console.WriteLine("Teste".Length);

            // ToUpper() -- tem () pq é um metodo Length é apenas um valor

            string valorImportante = null;
            //Console.WriteLine(valorImportante.Length); dá erro pq não funciona pra nulo
            Console.WriteLine(valorImportante?.Length); //o ? só acessa se a var tiver ok, tiver definida -- chamada de navegação segura
        }
    }
}

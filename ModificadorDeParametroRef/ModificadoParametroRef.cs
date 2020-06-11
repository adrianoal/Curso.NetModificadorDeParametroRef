using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorDeParametroRef
{
    class ModificadoParametroRef
    {
        /*
        //--------------------------------------------------------\\
        // Este metodo não funciona:
        // Esta solucao abaixo, esta dentro do escopo, por isso no programa principal nao funciona. 

        public static void Triple(int x) // Sem o Modificador Ref
        {
            x = x * 3;
        }
        //--------------------------------------------------------\\
        */

        // Este metodo funciona:
        // Ref faz referencia a variavel principal (Definida no Man)
        public static void Triple(ref int x) // Com o Modificador Ref
        {
            x = x * 3;
        }
    }
}

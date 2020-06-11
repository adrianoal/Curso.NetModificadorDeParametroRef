using System;

namespace ModificadorDeParametroRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ModificadoParametroRef.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}

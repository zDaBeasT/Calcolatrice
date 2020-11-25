using System;
using Operazioni;

namespace Calc1._0
{
    class Calc1_0
    {
        public static void Main(string[] args)
        {
            double n1 = Calcoli.Inserisci();
            string risposta = Calcoli.Operazione();
            double n2 = Calcoli.Inserisci();

            double? tot = Calcoli.Calcolo(n1, n2, risposta);

            Console.WriteLine(tot);
            Console.ReadLine();
        }
    }
}

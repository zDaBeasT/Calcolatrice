using System;

namespace Operazioni
{
    public class Calcoli
    {
        public static double Inserisci()
        {
            double n;
            Console.WriteLine("Inserisci il numero:");
            n = Convert.ToDouble(Console.ReadLine());
            return n;
        }
        public static string Operazione()
        {
            Console.WriteLine("operazione / operatore");
            string risp = Console.ReadLine();
            return risp;
        }
        public static double? Calcolo(double num1, double num2, string opz)
        {
            double? tot = null;

            switch (opz)
            {
                case "somma":
                case "Somma":
                case "SOMMA":
                case "+":
                    tot = num1 + num2;
                    break;
                case "sottrazione":
                case "Sottrazione":
                case "SOTTRAZIONE":
                case "-":
                    tot = num1 - num2;
                    break;
                case "prodotto":
                case "Prodotto":
                case "PRODOTTO":
                case "*":
                    tot = num1 * num2;
                    break;
                case "divisione":
                case "Divisione":
                case "DIVISIONE":
                case "/":
                    tot = num1 / num2;
                    break;
                default:
                    Errore();
                    break;



            }
            return tot;
        }

        public static void Errore()
        {
            Console.WriteLine("operazione non consentita");
        }
    }
}

        
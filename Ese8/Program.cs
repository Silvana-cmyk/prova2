using Ese8.Classi;
using System;

namespace Ese8
{
    class Program
    {
        static void Main(string[] args)
        {
            Erogatore erogatore = new Erogatore();

            int i = Menu();
            while (i != 0)
            {
                AnalizzaScelta(i, erogatore);
                i = Menu();
            }
        }

        private static int Menu()
        {
            Console.WriteLine("1. Scegli Merendina");
            Console.WriteLine("0. Premi 0 per uscire");

            int scelta;
            bool succ = Int32.TryParse(Console.ReadLine(), out scelta);

            if (succ != true || (scelta < 0 || scelta > 1))
            {
                Console.WriteLine();
                Console.WriteLine("Inserisci un valore corretto.");
                Console.WriteLine();
                scelta = 99;
                // break;
            }
            return scelta;
        }

        private static void AnalizzaScelta(int scelta, Erogatore e)
        {
            switch (scelta)
            {
                case 1:
                    Seleziona(e);
                    break;
                default:
                    scelta = 0;
                    break;
            }
        }

        private static void Seleziona(Erogatore e)
        {
            try
            {
                Console.WriteLine("Scegli un numero:");
                foreach (var item in e.ER)
                {
                    Console.Write(item.Key + ". ");
                    Console.WriteLine(item.Value.Nome);
                }
                int i = Convert.ToInt32(Console.ReadLine());
                while (!e.ER.ContainsKey(i))
                {
                    Console.WriteLine("Scegli un numero corretto:");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                bool succ = e.ER.TryGetValue(i, out Merendina merendina);
                Console.WriteLine("Inserisci soldi " + "PREZZO: " + merendina.Prezzo);
                double j = Convert.ToDouble(Console.ReadLine());
                while (merendina.Prezzo > j)
                {
                    Console.WriteLine("Inserisci soldi");
                    j = j + Convert.ToDouble(Console.ReadLine());
                }
                if (merendina.Prezzo == j)
                {
                    Console.WriteLine("Erogazione merendina:" + merendina.Nome);
                }
                else
                {
                    Console.WriteLine("Erogazione merendina: " + merendina.Nome);
                    double resto = j - merendina.Prezzo;
                    Console.WriteLine("Resto erogato: " + resto);
                }
            } catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }
    }
}

using System.Globalization;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadz wlasciciela dla nowego konta: ");

            string wlasc = Console.ReadLine();

            KontoBankowe konto = new KontoBankowe(wlasc);

            Automat automat = new Automat();


            while (true)
            {
                Console.Write("Wprowadz monetę do wplacenia: ");

                double moneta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                automat.WrzucMonete(konto, moneta);
            }
        }
    }
}

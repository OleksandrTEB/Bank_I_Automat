using System.Globalization;

namespace Bank
{
    class Automat
    {
        private readonly List<double> _monety;

        private int _iloscMonet;


        public Automat()
        {
            _monety = new List<double>();
            _iloscMonet = 0;

            _monety.Add(0.01);
            _monety.Add(0.02);
            _monety.Add(0.05);
            _monety.Add(0.10);
            _monety.Add(0.20);
            _monety.Add(0.50);
            _monety.Add(1);
            _monety.Add(2);
            _monety.Add(5);
        }

        public void WrzucMonete(KontoBankowe konto, string moneta)
        {
            bool result = double.TryParse(moneta, out double zparsowanaMoneta);

            if (result)
            {
                if (_monety.Contains(zparsowanaMoneta))
                {
                    Console.WriteLine($"Wplacono: {moneta}, Na konto znumerem: {konto.NrKonta}\n");
                    konto.Saldo += zparsowanaMoneta;
                    _iloscMonet++;
                    konto.StanKonta(_iloscMonet);
                }
                else
                {
                    Console.WriteLine("Takiej monety nie istnieje.");
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono niepoprany format!\n");
            }
        }
    }
}

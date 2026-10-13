namespace Bank
{
    class Automat
    {
        private List<double> _monety;

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

        public void WrzucMonete(KontoBankowe konto, double moneta)
        {
            if (_monety.Contains(moneta))
            {
                Console.WriteLine($"Wplacono: {moneta}, Na konto znumerem: {konto.NrKonta}\n");
                konto.Wplac(moneta);
                _iloscMonet++;
                konto.StanKonta(_iloscMonet);
            }
            else
            {
                Console.WriteLine("Takiej monety nie istnieje.");
            }
        }
    }
}

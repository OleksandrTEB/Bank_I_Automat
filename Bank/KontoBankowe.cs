namespace Bank
{
    class KontoBankowe
    {
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private string _nrKonta;
        public string NrKonta
        {
            get { return _nrKonta; }
        }

        private string _wlasciel;

        public KontoBankowe(string nowyWlasciciel)
        {
            _wlasciel = nowyWlasciciel;

            _nrKonta = GeneratorLosowychLiczb(10);

            Console.WriteLine($"Utworzono konto dla: {_wlasciel} z numerem konta: {_nrKonta}\n");
        }

        private string GeneratorLosowychLiczb(int dlugosNumeru)
        {
            Random r = new Random();

            string nr = "";

            for (int i = 0; i < dlugosNumeru; i++)
            {
                int num = r.Next(0, 11);

                nr += num;
            }

            return nr;
        }

        public void StanKonta(int iloscMonet)
        {
            Console.WriteLine($"Aktualny stan konta: {_saldo} zł, ilosc wrzuconych monet: {iloscMonet}");
        }
    }
}

using System;


namespace HW_3_OOP
{
    class Converter
    {
        private decimal _usd;
        private decimal _eur;

        public Converter(decimal usd, decimal eur)
        {
            _usd = usd;
            _eur = eur;
        }

        public decimal UahToUsd(decimal uahAmount)
        {
            return uahAmount / _usd;
        }

        public decimal UahToEur(decimal uahAmount)
        {
            return uahAmount / _eur;
        }

        public decimal UsdToUah(decimal usdAmount)
        {
            return usdAmount * _usd;
        }

        public decimal EurToUah(decimal eurAmount)
        {
            return eurAmount * _eur;
        }
    }
}

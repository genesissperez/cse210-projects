using System;

namespace OnlineOrdering
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        public bool IsInUsa()
        {
            // Convertimos a minúsculas para comparar de forma sencilla
            string countryClean = _country.ToLower().Trim();

            if (countryClean == "usa" || countryClean == "united states" || countryClean == "us")
            {
                return true;
            }

            return false;
        }

        public string GetFormattedAddress()
        {
            return _street + "\n" + _city + ", " + _state + "\n" + _country;
        }
    }
}
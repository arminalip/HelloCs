using System;
namespace WorldNamespace
{
    abstract class World
    {
        private string planetName;
        private Continents continents;


        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        public Continents Continents
        {
            get { return continents;}
            set { continents = value; }
        }

    }

    class Country : World
    {
        private string countryName;
        private string capital;
        private Currencies currency;
        private CountryLanguages countryLanguages;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public CountryLanguages CountryLanguages
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }

        public Country()
        {
            CountryName = "Unknown";
            Capital = "Unknown";
        }

        public void SayHi()
        {
            Console.WriteLine("Welome there...");
        }

        public void SayHi(string country)
        {
            Console.WriteLine("Welome pal from {0}", country);
        }
    }

    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }

    }

    enum Continents
    {
        Asia,
        Africa,
        Antarctica,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica
    }

    enum Currencies
    {
        USD,
        EUR,
        JPY,
        GBP,
        AUD,
        CAD,
        CHF,
        CNY,
        SEK,
        NZD,
        MXN,
        SGD,
        HKD,
        NOK,
        KRW,
        TRY,
        RUB,
        INR,
        EGP,
        BRL,
        ZAR,
        AED,
        TND,
        SAR,
        RON,
        PLN
    }

    enum Languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }



}




using System;
using ServiceStack;
using System.Collections.Generic;
namespace IntegrationWithWeatherService
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlOdessa = "https://goweather.herokuapp.com/weather/Odesa";
            string urlKiev = "https://goweather.herokuapp.com/weather/Kyiv";

            var weatherNowInOdessa = urlOdessa.GetJsonFromUrl().FromJson<Forecaster>();
            var weatherNowInKiev = urlKiev.GetJsonFromUrl().FromJson<Forecaster>();

            Console.WriteLine("Weather in Odessa");
            weatherNowInOdessa.print();

            Console.WriteLine("Weather in Kiev");
            weatherNowInKiev.print();
        }
        public class Forecaster
        {
            public string Temperature { get; set; }
            public string Wind { get; set; }
            public string Description { get; set; }
            public List<Forecast> Weather { get; set; }

            public void print()
            {
                Console.WriteLine(Temperature);
            }
        }

        public class Forecast
        {
            public int Day { get; set; }
            public string Temperature { get; set; }
            public string Wind { get; set; }
        }
    }
}
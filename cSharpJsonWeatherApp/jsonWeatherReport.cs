using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace cSharpJsonWeatherApp
{
    class DEFINECITIES
    {
        //From Poland
        public const string GDANSK_CITY_ID = "id=3099434&";
        public const string KRAKOW_CITY_ID = "id=3094802&";
        public const string RZESZOW_CITY_ID = "id=7530819&";
        public const string WARSAW_CITY_ID = "id=6695624&";

        //From US
        public const string NEW_YORK_CITY_ID = "id=5128638&";

        //Definition of names to collection
        public static string[] cityNames = new string[]
        {
            "Gdansk",
            "Krakow",
            "Rzeszow",
            "Warsaw",
            "New York"
        };
    }

    class SelectCity
    {
        //Last selected city
        private static string lastSelectedCity = "";

        public static string LastSelectedCity
        {
            get
            {
                return SelectCity.lastSelectedCity;
            }
            set
            {
                SelectCity.lastSelectedCity = value;
            }
        }

        private static bool checkCityName(string writeCity, string searchCity)
        {
            if (writeCity == searchCity)
            {
                return true;
            }
            return false;
        }

        /* Prepare city Id data to last call city */
        public static void getCityId(string cityName)
        {
            if (checkCityName(cityName, "Gdansk"))
            {
                SelectCity.LastSelectedCity = DEFINECITIES.GDANSK_CITY_ID;
            }
            else if (checkCityName(cityName, "Krakow"))
            {
                SelectCity.LastSelectedCity = DEFINECITIES.KRAKOW_CITY_ID;
            }
            else if (checkCityName(cityName, "Rzeszow"))
            {
                SelectCity.LastSelectedCity = DEFINECITIES.RZESZOW_CITY_ID;
            }
            else if (checkCityName(cityName, "Warsaw"))
            {
                SelectCity.LastSelectedCity = DEFINECITIES.WARSAW_CITY_ID;
            }
            else if (checkCityName(cityName, "New York"))
            {
                SelectCity.LastSelectedCity = DEFINECITIES.NEW_YORK_CITY_ID;
            }
            else
            {
                SelectCity.LastSelectedCity = DEFINECITIES.KRAKOW_CITY_ID;
            }
        }
    }


    // All function that is need to convert JSON data to other more
    // readable format
    public class conversionFunction
    {
        public static DateTime UnixTimeStampToDateTime(int epochTime)
        {
            DateTime newTime = new DateTime(1970, 1, 1).AddSeconds(epochTime);
            return newTime;
        }
    }

    public class GetWeatherDataWithTimeElapsed
    {
        // static TimeSpan startTimeSpan = TimeSpan.Zero;
        // static TimeSpan periodTimeSpan = TimeSpan.FromMinutes(5);

        // var timer = new System.Threading.Timer((e) =>
        //  {
        //
        // }, null, startTimeSpan, periodTimeSpan);
    }

    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public double Deg { get; set; }
    }

    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

    public class Sys
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("message")]
        public double Message { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty("sunset")]
        public int Sunset { get; set; }
    }

    public class JsonWeatherReport
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        public int Dt { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cod")]
        public int Cod { get; set; }
    }
}
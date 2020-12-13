using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace cSharpJsonWeatherApp
{
    public partial class WeatherApp : Form
    {
        /* Single weather */
        private const string APIKEY = "APPID=<HERE PUT YOUR API KEY>";
        private const string FORECAST_CLEAR = "http://api.openweathermap.org/data/2.5/weather?";

        /* Also there is a posibility to get weather data for 5 days with 3 hour resolution */
        private const string FORECAST_5DAYS = "http://api.openweathermap.org/data/2.5/forecast?";
        private const string READ_MODE = "&mode=json";
        private const string CITY_ID_BY_NAME = "q=Krakow,pl";

        public WeatherApp()
        {
            InitializeComponent();

            updateComboBoxCitiesData();

            MessageBox.Show(Properties.Settings.Default.countryRTBData.ToString());

            countriesComboBox.SelectedIndex = countriesComboBox.FindString(Properties.Settings.Default.countryRTBData.ToString());

            MessageBox.Show(Properties.Settings.Default.countryRTBData.ToString());
        }

        private void updateComboBoxCitiesData()
        {
            foreach(string cityName in DEFINECITIES.cityNames)
            {
                countriesComboBox.Items.Add(cityName);
            }

            countriesComboBox.Sorted = true;
            countriesComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            countriesComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            countriesComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private JsonWeatherReport getJsonData(string url)
        {
            using (WebClient client = new WebClient())
            {
                string receiveJson = client.DownloadString(url);

                JsonWeatherReport weather;

                weather = JsonConvert.DeserializeObject<JsonWeatherReport>(receiveJson);

                UpdateDataRichTxtBox(weather);
                
                return weather;
            }
        }

        private string makeRequestUrl(string cityID)
        {
            string requestAddr = FORECAST_CLEAR + cityID + APIKEY;
            return requestAddr;
        }

        private bool checkBoxCheckedCheck()
        {
            if (displJsonDataCheckBox.Checked == true)
            {
                return true;
            }
            return false;
        }

        private void displJsonDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckedCheck())
            {
                jsonWeatherRichTxtBox.Enabled = true;
            }
        }

        private void displRitchTxtBox(string txt)
        {
            jsonWeatherRichTxtBox.AppendText(txt + Environment.NewLine);
        }

        private void UpdateDataRichTxtBox(JsonWeatherReport weatherData)
        {
            if(checkBoxCheckedCheck() == false)
            {
                return;
            }

            displRitchTxtBox("Read forecast:");

            //Disp Localization Longtitude and Latitude
            double longi = weatherData.Coord.Lon;
            double lati = weatherData.Coord.Lat;

            displRitchTxtBox("City Cords:");
            displRitchTxtBox("Longitude: " + System.Convert.ToString(longi) + " ; Latitude: " + System.Convert.ToString(lati));

            //City ID
            string cityName = weatherData.Name;
            int cityId = weatherData.Id;
            int cod = weatherData.Cod;
            string country = weatherData.Sys.Country;

            displRitchTxtBox("City Name: " + cityName + country + " ;");
            displRitchTxtBox("City Id: " + System.Convert.ToString(cityId) + " ;");
            displRitchTxtBox("City Cod: " + System.Convert.ToString(cod) + " ;");

            //Main Info
            double tempKel = weatherData.Main.Temp;
            double tempCels = Math.Truncate((tempKel - 273) * 100) / 100;

            displRitchTxtBox("Read Temperature: C: " + System.Convert.ToString(tempCels) + "K: " + System.Convert.ToString(tempKel)  + " ;");

            int pressure = weatherData.Main.Pressure;
            int humidity = weatherData.Main.Humidity;

            displRitchTxtBox("Pressure: " + System.Convert.ToString(pressure) + " ;");
            displRitchTxtBox("Humidity " + System.Convert.ToString(humidity) + " ;");

            double tempMinKel = weatherData.Main.TempMin;
            double tempMinCels = Math.Truncate((tempMinKel - 273) * 100) / 100;

            double tempMaxKel = weatherData.Main.TempMax;
            double tempMaxCels = Math.Truncate((tempMaxKel - 273) * 100) / 100;

            displRitchTxtBox("Temperature Min: C: " + System.Convert.ToString(tempMinKel) + "K: " + System.Convert.ToString(tempMinCels) + " ;");
            displRitchTxtBox("Temperature Max: C: " + System.Convert.ToString(tempMaxKel) + "K: " + System.Convert.ToString(tempMaxCels) + " ;");

            //Wind
            double windSpeed = weatherData.Wind.Speed;
            double windDirection = weatherData.Wind.Deg;

            displRitchTxtBox("Wind Speed: " + System.Convert.ToString(pressure) + " ;");
            displRitchTxtBox("Wind Direction: " + System.Convert.ToString(humidity) + " ;");

            //Clouds
            int clouds = weatherData.Clouds.All;

            displRitchTxtBox("Clouds: " + System.Convert.ToString(clouds) + " ;");

            //Sys
            int type = weatherData.Sys.Type;
            int id = weatherData.Sys.Id;
            double message = weatherData.Sys.Message;
            int sunrise = weatherData.Sys.Sunrise;
            int sunset = weatherData.Sys.Sunset;

            displRitchTxtBox("Type: " + System.Convert.ToString(type) + " ;");
            displRitchTxtBox("Id: " + System.Convert.ToString(id) + " ;");
            displRitchTxtBox("Message: " + System.Convert.ToString(message) + " ;");

            //Convert sunrise and sunset Time to readable format
            DateTime sunriseTime = conversionFunction.UnixTimeStampToDateTime(sunrise);
            DateTime sunsetTime = conversionFunction.UnixTimeStampToDateTime(sunset);

            displRitchTxtBox("Sunrise Time: " + System.Convert.ToString(sunriseTime) + " ;");
            displRitchTxtBox("Sunset Time: " + System.Convert.ToString(sunsetTime) + " ;");
        }

        private void saveDataBetweenOpen()
        {
            Properties.Settings.Default.countryRTBData = countriesComboBox.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            //Check if RichTxtBox is empty, if it is then break
            if(countriesComboBox.SelectedIndex == -1 || countriesComboBox.SelectedItem.ToString() == "")
            {
                return;
            }

            saveDataBetweenOpen();

            SelectCity.getCityId(this.countriesComboBox.SelectedItem.ToString());

            string getDataUrl = makeRequestUrl(SelectCity.LastSelectedCity);

            jsonWeatherRichTxtBox.Clear();

            getJsonData(getDataUrl);
        }
    }
}

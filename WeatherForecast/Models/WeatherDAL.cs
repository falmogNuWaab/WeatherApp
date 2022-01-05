using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WeatherForecast.Models
{
    public class WeatherDAL
    {
        public Forecast GetGrandRapidsWeather()
        {
            string url = "https://api.weather.gov/gridpoints/GRR/38,46/forecast/";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Headers["User-Agent"] = ("Weather App, JamesMitchell@rocketmortgage.com");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();
            rd.Close();

            Forecast f = JsonConvert.DeserializeObject<Forecast>(result);
            return f;

        }
        public Forecast GetDetroitWeather()
        {
            string url = "https://api.weather.gov/gridpoints/DTX/53,33/forecast/";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Headers["User-Agent"] = ("Weather App, JamesMitchell@rocketmortgage.com");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();
            rd.Close();

            Forecast f = JsonConvert.DeserializeObject<Forecast>(result);
            return f;
        }
    }
}

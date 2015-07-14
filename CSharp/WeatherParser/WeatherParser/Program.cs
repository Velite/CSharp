using System;
using System.Globalization;
using System.Net;
using System.Net.Cache;
using System.Text;
using Newtonsoft.Json;

namespace WeatherParser
{
	public sealed class Weather
	{
		public float Temperature;
		public float Humidity;
		public float Pressure;
	}

	public class Program
	{
		static void Main()
		{
			using (WebClient web = new WebClient())
			{
				web.CachePolicy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, new TimeSpan(0));
				web.Encoding = Encoding.UTF8;
				string result = web.DownloadString("http://api.openweathermap.org/data/2.5/weather?id=524901&units=metric&lang=ru");
				if (!string.IsNullOrWhiteSpace(result))
				{
					dynamic val = JsonConvert.DeserializeObject(result);
					string tmp = val.main.pressure.ToString();
					Weather w = new Weather
					{
						Temperature = Convert.ToSingle(val.main.temp),
						Humidity = Convert.ToSingle(val.main.humidity),
						Pressure = tmp.HpaToMmhg()
					};
				}
			}
		}
	}

	public static class Extenders
	{
		public static float HpaToMmhg(this string val)
		{
			return Convert.ToSingle(val.Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat) * 0.75006375541921f;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Net;

namespace CurrencyGetter
{
	class Program
	{
		private static float getCurrency(string url)
		{
			float result = 0.0f;
			if (!string.IsNullOrWhiteSpace(url))
			{
				using (WebClient client = new WebClient())
				{
					string s = client.DownloadString(url).Replace("1\t", string.Empty).Replace("\n", string.Empty).Replace(".", ",");
					result = float.Parse(s);
				}
			}

			return result;
		}

		static void Main()
		{
			Dictionary<string, int> currencyCodes = new Dictionary<string, int> { { "USD", 840 }, { "EUR", 978 } };
			foreach (KeyValuePair<string, int> currencyCode in currencyCodes)
			{
				string url = string.Format("http://cbrates.rbc.ru/tsv/{0}/{1}.tsv", currencyCode.Value, DateTime.Now.ToString("yyyy/MM/dd").Replace(".", "/"));

				Console.WriteLine("1 {0} = {1} RUB", currencyCode.Key, getCurrency(url));
			}
			
			Console.ReadLine();
		}
	}
}
using System;

namespace PriceParser
{
	public static class Extenders
	{
		public static string ParseBrand(this string value)
		{
			return !string.IsNullOrWhiteSpace(value) ? value.Trim() : string.Empty;
		}

		public static Tuple<string, string> ParseNameNumber(this string value)
		{
			Tuple<string, string> result = new Tuple<string, string>(string.Empty, string.Empty);
			if (!string.IsNullOrWhiteSpace(value))
			{
				string modifiedValue = value.Replace("<br>", "#").Trim();
				if (!string.IsNullOrWhiteSpace(modifiedValue))
				{
					string[] parts = modifiedValue.Split('#');

					result = new Tuple<string, string>(parts[0].Trim(), parts[1].Trim());
				}
			}

			return result;
		}

		public static decimal ParsePrice(this string value)
		{
			decimal result = 0m;
			if (!string.IsNullOrWhiteSpace(value))
			{
				string modifiedValue = value.Replace(" ", string.Empty).Replace(".-", string.Empty).Replace("&nbsp;", string.Empty).Trim();
				if (!string.IsNullOrWhiteSpace(modifiedValue))
				{
					result = decimal.Parse(modifiedValue);
				}
			}

			return result;
		}
	}
}
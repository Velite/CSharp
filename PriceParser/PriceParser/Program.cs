using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;

namespace PriceParser
{
	internal sealed class Product
	{
		public string Brand;
		public string Name;
		public string Number;
		public decimal Price;
		public decimal OldPrice;
		public string Link;
		public string City;
		public string Season;
		public string Sex;
		public string Material;
	}

	class Program
	{
		static void Main()
		{
			List<Product> result = new List<Product>();

			HtmlWeb web = new HtmlWeb();
			HtmlDocument doc = web.Load("http://www.monro.biz/?page=coll&city=21&gcode=X&vt=02&pg=1&sr=1&gp=10");
			List<HtmlNode> products = doc.DocumentNode.SelectNodes("//div[@class='product-list']/ul/li").ToList();
			foreach (HtmlNode product in products)
			{
				Product newProduct = new Product
				{
					Sex = "F",
					City = "Moscow",
					OldPrice = 0.0m
				};

				HtmlNode link = product.SelectSingleNode(".//a");
				if (!string.IsNullOrWhiteSpace(link.Attributes["href"].Value))
				{
					string linkHref = WebUtility.HtmlDecode(link.Attributes["href"].Value);
					newProduct.Link = linkHref;

					HtmlWeb details = new HtmlWeb();
					HtmlDocument detailsDocument = details.Load(string.Format("http://www.monro.biz/{0}", linkHref));
					HtmlNode material = detailsDocument.DocumentNode.SelectSingleNode(".//table[@class='product_desc']/tr[3]/td[2]");
					newProduct.Material = material.InnerHtml.Trim();
				}

				HtmlNode brand = product.SelectSingleNode(".//span[@class='product_name']");
				newProduct.Brand = brand.InnerHtml.ParseBrand();

				HtmlNode name = product.SelectSingleNode(".//span[@class='product_desc']");
				Tuple<string, string> nameParts = name.InnerHtml.ParseNameNumber();
				newProduct.Name = nameParts.Item1;
				newProduct.Number = nameParts.Item2;

				HtmlNode price = product.SelectSingleNode(".//span[@class='product_price']");
				newProduct.Price = price.InnerHtml.ParsePrice();

				result.Add(newProduct);
			}
		}
	}
}
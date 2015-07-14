using System.Collections.Generic;
using System.Web.Mvc;
using RitOptMarket.Models;

namespace RitOptMarket.Controllers
{
	public class CatalogController : Controller
	{
		public ActionResult Index()
		{
			List<Coffin> coffins = new List<Coffin>
			{
				new Coffin
				{
					Name = "Стандарт",
					Category = "Детский",
					Material = string.Empty,
					Color = "Тёмно-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Child_900x600/child_standart_1.jpg"
				},
				new Coffin
				{
					Name = "Классика 6-гранник",
					Category = "Детский",
					Material = string.Empty,
					Color = "Белый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Child_900x600/child_classic_1.jpg"
				},
				new Coffin
				{
					Name = "Классика 6-гранник",
					Category = "Детский",
					Material = string.Empty,
					Color = "Тёмно-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Child_900x600/child_classic_2.jpg"
				},
				new Coffin
				{
					Name = "Классика 6-гранник",
					Category = "Детский",
					Material = string.Empty,
					Color = "Коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Child_900x600/child_classic_3.jpg"
				},
				new Coffin
				{
					Name = "Резной",
					Category = "Детский",
					Material = string.Empty,
					Color = "На выбор",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Child_900x600/child_carp.jpg"
				},
				new Coffin
				{
					Name = "Стандарт",
					Category = "Детский",
					Material = string.Empty,
					Color = "Белый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Child_900x600/child_standart_2.jpg"
				},
				new Coffin
				{
					Name = "Шестигранник",
					Category = "Гранд",
					Material = string.Empty,
					Color = "Тёмно-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Grand_900x600/grand_1.jpg"
				},
				new Coffin
				{
					Name = "Шестигранник",
					Category = "Гранд",
					Material = string.Empty,
					Color = "Коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Grand_900x600/grand_2.jpg"
				},
				new Coffin
				{
					Name = "Чертырёхгранник",
					Category = "Гранд",
					Material = string.Empty,
					Color = "Тёмно-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Grand_900x600/grand_3.jpg"
				},
				new Coffin
				{
					Name = "Тайная вечеря",
					Category = "Вегас",
					Material = string.Empty,
					Color = "Коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Vegas_900x600/vegas_1.jpg"
				},
				new Coffin
				{
					Name = "Тайная вечеря",
					Category = "Вегас",
					Material = string.Empty,
					Color = "Белый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Vegas_900x600/vegas_2.jpg"
				},
				new Coffin
				{
					Name = "Тайная вечеря",
					Category = "Вегас",
					Material = string.Empty,
					Color = "Тёмно-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Vegas_900x600/vegas_3.jpg"
				},
				new Coffin
				{
					Name = "Тайная вечеря",
					Category = "Вегас",
					Material = string.Empty,
					Color = "Коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Vegas_900x600/vegas_4.jpg"
				},
				new Coffin
				{
					Name = "Вегас",
					Category = "Вегас",
					Material = string.Empty,
					Color = "Тёмно-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Vegas_900x600/vegas_5.jpg"
				},
				new Coffin
				{
					Name = "6-гранник",
					Category = "Эконом",
					Material = string.Empty,
					Color = "Белый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Econom/6gr_ekonom_wh.jpg"
				},
				new Coffin
				{
					Name = "6-гранник",
					Category = "Эконом",
					Material = string.Empty,
					Color = "Коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Econom/6grannik_ekonom.jpg"
				},
				new Coffin
				{
					Name = "B4",
					Category = "Эконом",
					Material = string.Empty,
					Color = "Коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/B/B4_N.jpg"
				},
				new Coffin
				{
					Name = "Комби-4",
					Category = "Комби",
					Material = string.Empty,
					Color = "Розово-белый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Combi/combi_4_rose-wh.jpg"
				},
				new Coffin
				{
					Name = "Комби-4",
					Category = "Комби",
					Material = string.Empty,
					Color = "Чёрно-красный",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Combi/combi_4gr_blk-bord.jpg"
				},
				new Coffin
				{
					Name = "Комби-6",
					Category = "Комби",
					Material = string.Empty,
					Color = "Чёрно-жёлтый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Combi/combi_6gr_blk-gld.jpg"
				},
				new Coffin
				{
					Name = "Комби-6",
					Category = "Комби",
					Material = string.Empty,
					Color = "Чёрно-парчовый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Combi/combi_6gr_parcha.jpg"
				},
				new Coffin
				{
					Name = "Колода-4",
					Category = "Колода",
					Material = string.Empty,
					Color = "Коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Koloda/koloda_4gr_tem_N.jpg"
				},
				new Coffin
				{
					Name = "Питер-4",
					Category = "Питер",
					Material = string.Empty,
					Color = "Светло-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Piter_900x600/piter_4gr.jpg"
				},
				new Coffin
				{
					Name = "Питер-6",
					Category = "Питер",
					Material = string.Empty,
					Color = "Светло-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Piter_900x600/piter_6gr.jpg"
				},
				new Coffin
				{
					Name = "Питер-6",
					Category = "Питер",
					Material = string.Empty,
					Color = "Светло-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Piter_900x600/piter_6gr_clr.jpg"
				},
				new Coffin
				{
					Name = "Питер-БА",
					Category = "Питер",
					Material = string.Empty,
					Color = "Светло-коричневый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/Piter_900x600/Piter_ba.jpg"
				},
				new Coffin
				{
					Name = "Б-4",
					Category = "Б",
					Material = "Сосна",
					Color = "Белый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/B/Б-4 (сосна) белый.jpg"
				},
				new Coffin
				{
					Name = "Б-6",
					Category = "Б",
					Material = "Сосна",
					Color = "Белый",
					Exterior = "Глянец",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/B/Б-6 (сосна) белый глянец.jpg"
				},
				new Coffin
				{
					Name = "Б-6",
					Category = "Б",
					Material = "Сосна",
					Color = "Светлый",
					Exterior = "Глянец",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/B/Б-6 (сосна) светлый глянец.jpg"
				},
				new Coffin
				{
					Name = "Б-6",
					Category = "Б",
					Material = "Сосна",
					Color = "Тёмный",
					Exterior = "Матовый",
					Price = 0.0m,
					ImageUrl = "../Images/Coffins/B/Б-6 (сосна) тёмный матовый.jpg"
				}
			};

			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Гробы лакированные";

			return View(coffins);
		}

		public ActionResult CoffinsCombined()
		{
			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Гробы комбинированные";

			return View();
		}

		public ActionResult CoffinsCloth()
		{
			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Гробы обитые тканью";

			return View();
		}

		public ActionResult Flowers()
		{
			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Венки";

			return View();
		}

		public ActionResult IronCrosses()
		{
			List<Item> crosses = new List<Item>
			{
				new Item
				{
					Name = "Вензеля",
					Category = "Кресты",
					Price = 0.0m,
					PreviewImageUrl = "../Images/Crosses/cross_venz_preview.jpg",
					ImageUrl = "../Images/Crosses/cross_venz.jpg"
				},
				new Item
				{
					Name = "Завитушка",
					Category = "Кресты",
					Price = 0.0m,
					PreviewImageUrl = "../Images/Crosses/cross_zav_preview.jpg",
					ImageUrl = "../Images/Crosses/cross_zav.jpg"
				},
				new Item
				{
					Name = "Золотой",
					Category = "Кресты",
					Price = 0.0m,
					PreviewImageUrl = "../Images/Crosses/cross_gold_preview.jpg",
					ImageUrl = "../Images/Crosses/cross_gold.jpg"
				},
				new Item
				{
					Name = "Купола",
					Category = "Кресты",
					Price = 0.0m,
					PreviewImageUrl = "../Images/Crosses/cross_dome_preview.jpg",
					ImageUrl = "../Images/Crosses/cross_dome.jpg"
				},
				new Item
				{
					Name = "Православный",
					Category = "Кресты",
					Price = 0.0m,
					PreviewImageUrl = "../Images/Crosses/cross_pagan_preview.jpg",
					ImageUrl = "../Images/Crosses/cross_pagan.jpg"
				},
				new Item
				{
					Name = "Стандарт",
					Category = "Кресты",
					Price = 0.0m,
					PreviewImageUrl = "../Images/Crosses/cross_standart_preview.jpg",
					ImageUrl = "../Images/Crosses/cross_standart.jpg"
				},
			};

			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Металлические кресты";

			return View(crosses);
		}

		public ActionResult WoodenCrosses()
		{
			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Деревянные кресты";

			return View();
		}

		public ActionResult Stripes()
		{
			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Ленты";

			return View();
		}

		public ActionResult Backgrounds()
		{
			List<Item> stripes = new List<Item>
			{
				new Item
				{
					Name = "80 см Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/80 см ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/80 см ерш.jpg"
				},
				new Item
				{
					Name = "80 см Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/80 см комби.jpg",
					PreviewImageUrl = "../Images/Stripes/80 см комби.jpg"
				},
				new Item
				{
					Name = "90 см Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/90 см ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/90 см ерш.jpg"
				},
				new Item
				{
					Name = "90 см Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/90 см комби.jpg",
					PreviewImageUrl = "../Images/Stripes/90 см комби.jpg"
				},
				new Item
				{
					Name = "110 см Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/110 см ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/110 см ерш.jpg"
				},
				new Item
				{
					Name = "110 см Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/110 см комби.jpg",
					PreviewImageUrl = "../Images/Stripes/110 см комби.jpg"
				},
				new Item
				{
					Name = "125 см Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/125 см ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/125 см ерш.jpg"
				},
				new Item
				{
					Name = "125 см Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/125 см комби.jpg",
					PreviewImageUrl = "../Images/Stripes/125 см комби.jpg"
				},
				new Item
				{
					Name = "140 см Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/140 см ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/140 см ерш.jpg"
				},
				new Item
				{
					Name = "140 см Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/140 см комби.jpg",
					PreviewImageUrl = "../Images/Stripes/140 см комби.jpg"
				},
				new Item
				{
					Name = "160 см Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/160 см ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/160 см ерш.jpg"
				},
				new Item
				{
					Name = "160 см Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/160 см комби.jpg",
					PreviewImageUrl = "../Images/Stripes/160 см комби.jpg"
				},
				new Item
				{
					Name = "180 см Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/140 см ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/140 см ерш.jpg"
				},
				new Item
				{
					Name = "180 см Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/180 см комби.jpg",
					PreviewImageUrl = "../Images/Stripes/180 см комби.jpg"
				},
				new Item
				{
					Name = "Капля Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/капля ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/капля ерш.jpg"
				},
				new Item
				{
					Name = "Капля Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/капля комби.jpg",
					PreviewImageUrl = "../Images/Stripes/капля комби.jpg"
				},
				new Item
				{
					Name = "Колесо Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/колесо ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/колесо ерш.jpg"
				},
				new Item
				{
					Name = "Круг Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/круг ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/круг ерш.jpg"
				},
				new Item
				{
					Name = "Круг Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/круг комби.jpg",
					PreviewImageUrl = "../Images/Stripes/круг комби.jpg"
				},
				new Item
				{
					Name = "Ладья большая Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/ладья большая ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/ладья большая ерш.jpg"
				},
				new Item
				{
					Name = "Ладья большая Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/ладья большая комби.jpg",
					PreviewImageUrl = "../Images/Stripes/ладья большая комби.jpg"
				},
				new Item
				{
					Name = "Ладья малая Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/ладья малая ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/ладья малая ерш.jpg"
				},
				new Item
				{
					Name = "Ладья малая Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/ладья малая комби.jpg",
					PreviewImageUrl = "../Images/Stripes/ладья малая комби.jpg"
				},
				new Item
				{
					Name = "Ладья средняя Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/ладья средняя ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/ладья средняя ерш.jpg"
				},
				new Item
				{
					Name = "Полуваза Аура Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/полуваза аура ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/полуваза аура ерш.jpg"
				},
				new Item
				{
					Name = "Полуваза Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/полуваза ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/полуваза ерш.jpg"
				},
				new Item
				{
					Name = "Полуваза Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/полуваза комби.jpg",
					PreviewImageUrl = "../Images/Stripes/полуваза комби.jpg"
				},
				new Item
				{
					Name = "Саша (без ручки) Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/саша без ручки комби.jpg",
					PreviewImageUrl = "../Images/Stripes/саша без ручки комби.jpg"
				},
				new Item
				{
					Name = "Саша (с ручкой) Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/саша с ручкой комби.jpg",
					PreviewImageUrl = "../Images/Stripes/саша с ручкой комби.jpg"
				},
				new Item
				{
					Name = "Стульчик Ёрш",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/стульчик ерш.jpg",
					PreviewImageUrl = "../Images/Stripes/стульчик ерш.jpg"
				},
				new Item
				{
					Name = "Стульчик Комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/стульчик комби.jpg",
					PreviewImageUrl = "../Images/Stripes/стульчик комби.jpg"
				},
				new Item
				{
					Name = "Таиара (без ручки)",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/тамара без ручки.jpg",
					PreviewImageUrl = "../Images/Stripes/тамара без ручки.jpg"
				},
				new Item
				{
					Name = "Тамара (с ручкой)",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/тамара с ручкой.jpg",
					PreviewImageUrl = "../Images/Stripes/тамара с ручкой.jpg"
				},
				new Item
				{
					Name = "Тамара (с ручкой) комби",
					Category = "Ленты",
					Price = 0.0m,
					ImageUrl = "../Images/Stripes/тамара с ручкой комби.jpg",
					PreviewImageUrl = "../Images/Stripes/тамара с ручкой комби.jpg"
				}
			};

			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Фоны";

			return View(stripes);
		}

		public ActionResult Other()
		{
			List<Stuff> stuff = new List<Stuff>
			{
				new Stuff
				{
					Name = "Рубаха",
					Color = "Чёрный",
					Category = "Прочее",
					Price = 0.0m,
					Model = "Рубаха-1Ч",
					ImageUrl = "../Images/Other/Shirt.jpg"
				},
				new Stuff
				{
					Name = "Накидка на гроб",
					Color = "Белый",
					Category = "Прочее",
					Price = 0.0m,
					Model = "Накидка-1Б",
					ImageUrl = "../Images/Other/Cover.jpg"
				}
			};

			ViewBag.ActiveButtonId = "Catalog";
			ViewBag.Title = "Прочее";

			return View(stuff);
		}
	}
}
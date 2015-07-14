using System.Web.Mvc;

namespace RitOptMarket.Controllers
{
	public class GuaranteeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Гарантия";
			ViewBag.ActiveButtonId = "Guarantee";
			ViewBag.Message = "<ul><li>Мы гарантируем своевременную доставку и качество продукции. Доставка осуществляется надёжным транспортом, что позволяет доставить груз в нужное время.</li><li>Вся продукция имеет гарантию.</li><li>Вся лаковая продукция (кресты, гробы), при порче внешнего вида из-за долгой не реализации, меняется бесплатно.</li></ul>";

			return View();
		}
	}
}
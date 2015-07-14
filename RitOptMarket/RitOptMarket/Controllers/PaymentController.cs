using System.Web.Mvc;

namespace RitOptMarket.Controllers
{
	public class PaymentController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Оплата";
			ViewBag.ActiveButtonId = "Payment";
			ViewBag.Message = "<ul><li>Все цены указаны с доставкой.</li><li>Весь представленный ассортимент всегда есть в наличии.</li><li>Оплата производится за наличный и безналичный расчёт.</li></ul>";

			return View();
		}
	}
}
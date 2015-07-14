using System.Web.Mvc;

namespace RitOptMarket.Controllers
{
	public class ContactsController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Контакты";
			ViewBag.ActiveButtonId = "Contacts";

			return View();
		}
	}
}
using System.Web.Optimization;

namespace RitOptMarket
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/modernizir").Include("~/Scripts/modernizir.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery.js"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
			bundles.Add(new ScriptBundle("~/bundles/menu").Include("~/Scripts/menu.js"));

			bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include("~/Content/css/bootstrap.css"));
			bundles.Add(new StyleBundle("~/Content/css/site").Include("~/Content/css/site.css"));
		}
	}
}
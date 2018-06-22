using System.Web;
using System.Web.Optimization;

namespace SICI
{
	public class BundleConfig


	{
		public static void RegisterBundle(BundleCollection Bundles)
		{

			Bundles.Add(new StyleBundle("~/bundles/css")
				.Include(
				"~/Content/vendor/bootstrap/css/bootstrap.min.css",
				"~/Content/vendor/metisMenu/metisMenu.min.css",
				"~/Content/dist/css/sb-admin-2.css",
				"~/Content/vendor/font-awesome/css/font-awesome.min.css"));

			Bundles.Add(new ScriptBundle("~/bundles/js")
				.Include(
				"~/Content/vendor/jquery/jquery.min.js",
				"~/Content/vendor/bootstrap/js/bootstrap.min.js",
				"~/Content/vendor/metisMenu/metisMenu.min.js",
				"~/Content/vendor/raphael/raphael.min.js",
				"~/Content/dist/js/sb-admin-2.js"));

		}

	}

}
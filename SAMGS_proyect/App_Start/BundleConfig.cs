using System.Web;
using System.Web.Optimization;

namespace SAMGS
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquerySAMGS").Include(
                        //< !--Bootstrap core JavaScript-- >
                        "~/vendor/jquery/jquery.min.js",
                        "~/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        //< !--Core plugin JavaScript-- >
                        "~/vendor/jquery-easing/jquery.easing.min.js",
                        //< !--Custom scripts for all pages-->
                        "~/js/sb-admin-2.min.js",
                        //< !--Page level plugins-- >
                        "~/vendor/chart.js/Chart.min.js",
                        //< !--Page level custom scripts-- >
                        "~/js/demo/chart-area-demo.js",
                        "~/js/demo/chart-pie-demo.js"
                ));
            //css
            bundles.Add(new StyleBundle("~/Content/cssSAMGS").Include(
                 //< !--Custom fonts for this template-- >
                 "~/vendor/fontawesome-free/css/all.min.css",
                  //< !--Custom styles for this template-- >
                  "~/css/sb-admin-2.min.css"
                ));

            
        }
    }
}

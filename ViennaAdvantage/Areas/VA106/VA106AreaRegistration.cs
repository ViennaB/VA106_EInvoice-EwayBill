using System.Web.Mvc;
using System.Web.Optimization;



//NOTE:--    Please replace ViennaAdvantage with prefix of your module..



namespace VA106 //  Please replace namespace with prefix of your module..
{
    public class ViennaAdvantageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VA106";   //Please replace "ViennaAdvantage" with prefix of your module.......
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VA106_default",
                "VA106/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
                , new[] { "VA106.Controllers" }
            );    // Please replace ViennaAdvantage with prefix of your module...


            StyleBundle style = new StyleBundle("~/Areas/VA106/Contents/VA106Style");
           
            ScriptBundle script = new ScriptBundle("~/Areas/VA106/Scripts/VA106Js");


            //script.Include("~/Areas/VA106/Scripts/model/callouts.js");

            script.Include("~/Areas/VA106/Scripts/VA106.all.min.js");
            style.Include("~/Areas/VA106/Contents/VA106.all.min.css");



            /*-------------------------------------------------------
                    Here include all js files in style bundle......see example below....
            
              Please replace "ViennaAdvantage" with prefix of your module..
             * 
             * 1. first parameter is script/style bundle...
             * 
             * 2. Second parameter is module prefix...
             * 
             * 3. Third parameter is order of loading... (dafault is 10 )
             * 
             --------------------------------------------------------*/

            VAdvantage.ModuleBundles.RegisterScriptBundle(script, "VA106", 10);
            VAdvantage.ModuleBundles.RegisterStyleBundle(style, "VA106", 10);
        }
    }
}
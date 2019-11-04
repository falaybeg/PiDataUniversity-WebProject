using System.Web.Mvc;

namespace NTierApp.Areas.Fakulteler
{
    public class FakultelerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Fakulteler";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Fakulteler_default",
                "Fakulteler/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
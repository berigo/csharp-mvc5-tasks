using System.Web.Mvc;

namespace WebApp.Areas.Task001
{
    public class Task001AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Task001";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Task001_default",
                "Task001/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
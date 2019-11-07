using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using PiData.BLL.Interface;
using PiData.BLL.ServiceBusiness;
using PiDataApp.Repository.Infrastucture;
using PiDataApp.Repository.Infrastucture.Contract;
using PiDataWebApp.Resolver;
using Unity;

namespace PiDataWebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<ICourseBusiness, CourseBusiness>();
            container.RegisterType<IUniversityInfoBusiness, UniversityInfoBusiness>();
            container.RegisterType<IUniversityNewsBusiness, UniversityNewsBusiness>();
            container.RegisterType<IUniversityAnnouncementBusiness, UniversityAnnouncementBusiness>();
            container.RegisterType<IAcademicCalendarBusiness, AcademicCalendarBusiness>();
            container.RegisterType<IStudentBusiness, StudentBusiness>();

            config.DependencyResolver = new UnityResolver(container);


            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );



            /*
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors();

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
            */

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
        }
    }
}

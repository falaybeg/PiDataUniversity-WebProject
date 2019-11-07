using PiData.BLL.Interface;
using PiData.BLL.ServiceBusiness;
using PiDataApp.Repository.Infrastucture;
using PiDataApp.Repository.Infrastucture.Contract;
using PiDataWebApp.Areas.HelpPage.Controllers;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace PiDataWebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<ICourseBusiness, CourseBusiness>();
            container.RegisterType<IUniversityInfoBusiness, UniversityInfoBusiness>();
            container.RegisterType<IUniversityNewsBusiness, UniversityNewsBusiness>();
            container.RegisterType<IUniversityAnnouncementBusiness, UniversityAnnouncementBusiness>();
            container.RegisterType <IFacultyInfoBusiness, FacultyInfoBusiness>();
            container.RegisterType<IDepartmentInfoBusiness, DepartmentInfoBusiness>();
            container.RegisterType<IAcademicCalendarBusiness, AcademicCalendarBusiness>();
            container.RegisterType<IStudentBusiness, StudentBusiness>();

            container.RegisterType<HelpController>(new InjectionConstructor());



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
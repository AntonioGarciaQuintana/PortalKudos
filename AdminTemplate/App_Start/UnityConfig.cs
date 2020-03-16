using Core.Repository;
using Core.Repository.Interfaces;
using Core.Service;
using Core.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AdminTemplate
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IStudentService, StudentService>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using NHibernate;
using NHibernate.Context;
using NHibernate.Cfg;
using PracticeNHibernateMVC.Mappings;

namespace PracticeNHibernateMVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        
        //public static ISessionFactory NHibernateSessionFactory;

        //public override void Init()
        //{
        //    base.Init();

        //    this.BeginRequest += new EventHandler(MvcApplication_BeginRequest);
        //    this.EndRequest += new EventHandler(MvcApplication_EndRequest);
        //}

        //void MvcApplication_BeginRequest(object sender, EventArgs e)
        //{
        //    var session = NHibernateSessionFactory.OpenSession();
        //    CurrentSessionContext.Bind(session);
        //}

        //void MvcApplication_EndRequest(object sender, EventArgs e)
        //{
        //    var session = CurrentSessionContext.Unbind(NHibernateSessionFactory);
        //    session.Dispose();
        //}

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //NHibernateSessionFactory = Configuration.NHibernateHelper.GetNHibernateSessionFactory();
        }
    }
}
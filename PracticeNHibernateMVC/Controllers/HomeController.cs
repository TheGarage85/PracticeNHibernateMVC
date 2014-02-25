using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate.Cfg;
using NHibernate;
using PracticeNHibernateMVC.Mappings;

namespace PracticeNHibernateMVC.Controllers
{
    public class HomeController : Controller
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public ActionResult Index()
        {
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            using (mySession.BeginTransaction())
            {
                Page newPage = new Page { Name = "test", Namespace = "test" };
                mySession.Save(newPage);
                mySession.Transaction.Commit();
            }

            return View();
        }
    }
}

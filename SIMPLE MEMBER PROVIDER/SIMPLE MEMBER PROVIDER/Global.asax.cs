using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using WebMatrix.WebData;

namespace SIMPLE_MEMBER_PROVIDER
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            InitialiazedDatabaseConnection();
        }

        private void InitialiazedDatabaseConnection()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("test", "Users", "Id", "Username", true);
                // WebSecurity.CreateUserAndAccount("Kumail", "June8");
                //Roles.CreateRole("Administrator");
                //Roles.CreateRole("Manager");
                //Roles.CreateRole("Users");
                //Roles.AddUserToRole("Kumail", "Administrator");
               
            }
        }
    }
}

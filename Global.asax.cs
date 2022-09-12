using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Final_Project
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            SupremePackage.MaxNumOfMuseums = 5;
            PrimePackage.MaxNumOfMuseums = 4;
            BasicPackage.MaxTotalPrice = 30;
            BasicPackage.MaxNumOfMuseums = 3;
        }
    }
}
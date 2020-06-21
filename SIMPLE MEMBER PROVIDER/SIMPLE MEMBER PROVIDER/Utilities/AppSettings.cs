using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SIMPLE_MEMBER_PROVIDER.Utilities
{
    public class AppSettings
    {
        public static string ConnectionStrings()
        {
            return ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        }
    }
}
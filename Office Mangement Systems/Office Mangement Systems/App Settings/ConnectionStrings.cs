using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Mangement_Systems.App_Settings
{
   public class ConnectionStrings
    {
        public static string DBConnection()
        {
            return ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        }
    }
}

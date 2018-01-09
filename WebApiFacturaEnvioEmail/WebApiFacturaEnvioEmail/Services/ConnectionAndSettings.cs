using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFacturaEnvioEmail.Services
{
    public class ConnectionAndSettings
    {
        public static string ConnectionString { get { return System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DataConnectionString"].ToString(); } }        
    }
}
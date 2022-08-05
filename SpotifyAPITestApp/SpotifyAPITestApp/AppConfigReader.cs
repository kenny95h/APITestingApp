using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp
{
    public class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string AuthToken = ConfigurationManager.AppSettings["auth_token"];
        public static readonly string UserID = ConfigurationManager.AppSettings["user_id"];
    }
}

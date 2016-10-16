using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core.Configuration
{
    public static class ConfigurationManager
    {
        private const string Log4netConfig = "ConfigurationLog4Net";
        private const string pathLogConfig = "pathLogConfig";
        public static readonly Dictionary<string, string> Configuration = GetConfiguration();
        private static Dictionary<string, string> GetConfiguration()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Configuration.ConfigurationManager.AppSettings[pathLogConfig] + "log4net.config");

            var log4netS = System.Configuration.ConfigurationManager.AppSettings[Log4netConfig];
            Dictionary<string, string> parametresGlobaux = new Dictionary<string, string>();
            parametresGlobaux.Add(log4netS, doc.InnerXml.ToString());
            return parametresGlobaux;
        }
    }
}

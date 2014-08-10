using System.Configuration;
using System.Globalization;

namespace SpecFlowTest.Helpers
{
    static class  ConfigSettings
    {
        public static double SpeedFactor
        {
            get
            {
                var sf = ConfigurationManager.AppSettings["SpeedFactor"] ?? "1";
                return double.Parse(sf);
            }
        }

        public static string GetKeyValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString(CultureInfo.InvariantCulture);
        }
    }
}

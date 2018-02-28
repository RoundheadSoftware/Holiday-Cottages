using System.Configuration;

namespace Core
{
    public class Constants
    {
        public static string Constant = "Here's a string";
        public static string DateFormat = "";
        public static int CachingInMinutes
        {
            get
            {
                return Helpers.DataHelper.TryConvertInt(ConfigurationManager.AppSettings["CachingInMinutes"]);
            }
        }
    }
}

using System.Configuration;

namespace Core
{
    public class Constants
    {
        public class GeneralConstants
        {
            public static string Constant = "Here's a string";
            public static string ShortDateFormat = "dd/MM/yy";
            public static string LongDateFormat = "dddd, dd MMMM yyyy";
            public static int CachingInMinutes
            {
                get
                {
                    return Helpers.DataHelper.TryConvertInt(ConfigurationManager.AppSettings["CachingInMinutes"]);
                }
            }
        }
        public class DocumentTypes
        {
            public class Hero
            {
                public static string Title = "pageTitle";
                public static string Subtitle = "pageSubtitle";
                public static string HeroImage = "heroImage";
                public static string ShowTitle = "showTitle";
                public static string ShowDescription = "showDescription";

            }

        }
    }
}

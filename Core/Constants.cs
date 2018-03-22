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
            public class Content
            {
                public static string Title = "title";
                public static string BodyContent = "bodyContent";
            }
            public class Sidebar
            {
                public static string Title = "sidebarTitle";
                public static string Text = "sidebarText";
                public static string ShowFacebookPage = "showFacebookPage";
                public static string FacebookIntroduction = "facebookIntroduction";
                public static string FacebookPageURL = "facebookPageURL";
                public static string FacebookPageName = "facebookPageName";
                public static string ShowGoogleTranslate = "showGoogleTranslate";
                public static string GoogleTranslateIntroduction = "googleTranslateIntroduction";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public class DataHelper
    {
        public static int TryConvertInt(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (Exception ex)
            {
                LogError(ex);
                return 0;
            }
        }
        public static void LogError(Exception ex)
        {
            //to-do: log error
            throw ex;
        }
    }
}

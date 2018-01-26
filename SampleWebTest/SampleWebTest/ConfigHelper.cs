namespace SampleWebTest
{
    using System.Configuration;

    public static class SeleniumConfigHelper
    {
        public static string GetStringValue(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return value;
        }

        public static bool GetBoolValue(string key)
        {
            bool value = bool.Parse(GetStringValue(key));
            return value;
        }
        public static int GetIntValue(string key)
        {
            int value = int.Parse(GetStringValue(key));
            return value;
        }
    }
}

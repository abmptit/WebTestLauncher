namespace SampleWebTest.SiteMap
{
    using System.IO;
    using System.Reflection;
    using Newtonsoft.Json;
    using SampleWebTest.SiteMap.Models;

    public static class SiteMapHelper
    {
        public static Page LoadPageFromJson(string jsonFile)
        {
            var projectOutputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var jsonFileAbsolutePath = Path.Combine(
                projectOutputDirectory,
                $"sitemap\\{jsonFile}");

            using (StreamReader r = new StreamReader(jsonFileAbsolutePath))
            {
                string json = r.ReadToEnd();
                Page page = JsonConvert.DeserializeObject<Page>(json);
                return page;
            }


        }
    }
}

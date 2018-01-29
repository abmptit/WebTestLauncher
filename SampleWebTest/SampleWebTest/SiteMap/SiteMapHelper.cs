namespace SampleWebTest.SiteMap
{
    using Newtonsoft.Json;
    using SampleWebTest.Common.Model.SiteMap;
    using System.IO;

    public static class SiteMapHelper
    {

        public static Page LoadPageFromJson(string jsonFile)
        {
            using (StreamReader r = new StreamReader(jsonFile))
            {
                string json = r.ReadToEnd();
                Page page = JsonConvert.DeserializeObject<Page>(json);
                return page;
            }
        }

    }
}

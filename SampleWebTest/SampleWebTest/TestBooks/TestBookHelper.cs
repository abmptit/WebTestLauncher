namespace SampleWebTest.TestBooks
{
    using System.Reflection;
    using Newtonsoft.Json;
    using System.IO;
    using SampleWebTest.TestBooks.Models;
    using SampleWebTest.SiteMap.Models;

    public static class TestBookHelper
    {
        public static Test ReadTestFromJson(string jsonFile)
        {
            var projectOutputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var jsonFileAbsolutePath = Path.Combine(
                projectOutputDirectory, 
                jsonFile);
            if (!File.Exists(jsonFileAbsolutePath)) {
                throw new FileNotFoundException($"{jsonFileAbsolutePath} not founded");
            }

            using (StreamReader r = new StreamReader(jsonFileAbsolutePath))
            {
                string json = r.ReadToEnd();
                Test test = JsonConvert.DeserializeObject<Test>(json);
                return test;
            }
        }

        public static Test ConvertFromPageObject(this Test test)
        {
            foreach (var step in test.Steps)
            {
                step.ConvertFromPageObject();
            }
            return test;
        }

        public static Step ConvertFromPageObject(this Step step)
        {
            foreach(var property in step.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                {
                   string value = property.GetValue(step, null)?.ToString();
                   if (value != null && value.StartsWith("#"))
                    {
                        var pageKey = value.Substring(1).Split('.')[0];
                        var pageComponent = value.Substring(1).Split('.')[1];
                        var page = SiteMap.Instance.GetPage(pageKey);
                        var siteMapValue = page.GetType().GetProperty(pageComponent).GetValue(page, null).ToString();
                        property.SetValue(step, siteMapValue);
                    }
                }
            }
            return step;
        }
    }
}

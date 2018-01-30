namespace SampleWebTest.TestBooks
{
    using System.Reflection;
    using Newtonsoft.Json;
    using System.IO;
    using SampleWebTest.TestBooks.Models;

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
    }
}

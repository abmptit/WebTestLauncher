namespace SampleWebTest
{
    using SampleWebTest.Common.Enum;
    using Newtonsoft.Json;
    using System.IO;
    using System;
    using OpenQA.Selenium;
    using SampleWebTest.Common.Helpers;

    public static class SeleniumTestExecutor
    {
        //public static string CreateJsonSampleTest()
        //{
        //    Test newTest = new Test() { Name = "My First Test", Description = "This Test ..." };
        //    Step createSession = new Step() { Type = StepType.CREATE_SESSION, Name = "Open the browser", Description = "This step open the browser" };
        //    newTest.Steps.Add(createSession);
        //    string jsonTest = JsonConvert.SerializeObject(newTest);
        //    return jsonTest;
        //}

        //public static void Execute(this Test test)
        //{
        //    IWebDriver testWebDriver = null;
        //    foreach (Step step in test.Steps)
        //    {
        //        step.Execute(ref testWebDriver);
        //    }
        //}

        //public static void Execute(this Step step, ref IWebDriver webDriver)
        //{
        //    switch(step.Type)
        //    {
        //        case (StepType.CREATE_SESSION):
        //            webDriver = WebDriverHelper.CreateSession();
        //            webDriver.ResizeWindow(SeleniumConfig.BrowserSize);
        //            break;
        //        case (StepType.NAVIGATE_URL):
        //            webDriver.Url = step.Url;
        //            webDriver.Navigate().GoToUrl(step.Url);
        //            break;
        //        case (StepType.CLICK_BUTTON):
        //            break;
        //        case (StepType.TAKE_SCREENSHOT):
        //            break;
        //        case (StepType.RESIZE_WINWDOW):
        //            webDriver.ResizeWindow(SeleniumConfig.BrowserSize);
        //            break;
        //        default:
        //            throw new NotImplementedException();

        //    }
        //}

        //public static void ExecuteTestFromJson(string jsonFile)
        //{
        //    var test = ReadTestFromJson(jsonFile);
        //    test.Execute();
        //}

        //public static Test ReadTestFromJson(string jsonFile)
        //{
        //    using (StreamReader r = new StreamReader(jsonFile))
        //    {
        //        string json = r.ReadToEnd();
        //        Test test = JsonConvert.DeserializeObject<Test>(json);
        //        return test;
        //    } 
        //}        
    }
}

namespace SampleWebTest
{
    using Common.Model;
    using SampleWebTest.Common.Enum;
    using Newtonsoft.Json;
    using System.IO;
    using System.Collections.Generic;
    using System;

    public static class SeleniumTestExecutor
    {
        public static string CreateJsonSampleTest()
        {
            Test newTest = new Test() { Name = "My First Test", Description = "This Test ..." };
            Step createSession = new Step() { Type = StepType.CREATE_SESSION, Name = "Open the browser", Description = "This step open the browser" };
            newTest.Steps.Add(createSession);
            string jsonTest = JsonConvert.SerializeObject(newTest);
            return jsonTest;
        }

        public static void Execute(this Test test)
        {            
            foreach(Step step in test.Steps)
            {
                step.Execute();
            }
        }

        public static void Execute(this Step step)
        {
            switch(step.Type)
            {
                case (StepType.CREATE_SESSION):
                    break;
                case (StepType.NAVIGATE_URL):
                    break;
                default:
                    throw new NotImplementedException();

            }
        }

        public static void ExecuteTestFromJson(string jsonFile)
        {
            var test = ReadTestFromJson(jsonFile);
            test.Execute();
        }

        public static Test ReadTestFromJson(string jsonFile)
        {
            using (StreamReader r = new StreamReader(jsonFile))
            {
                string json = r.ReadToEnd();
                Test test = JsonConvert.DeserializeObject<Test>(json);
                return test;
            } 
        }

        public static void CreateTest(Step step)
        {


        }

        public static void ExecuteStep(Step step)
        {


        }

        public static void ExecuteTest(Test test)
        {


        }
    }
}

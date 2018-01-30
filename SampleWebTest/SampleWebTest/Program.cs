namespace SampleWebTest
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //var jsonTest = SeleniumTestExecutor.CreateJsonSampleTest();

            //SeleniumTestExecutor.ExecuteTestFromJson("TestBooks/Simple/CreateChromeSession.json");
            SeleniumTestExecutor.ExecuteTestFromJson("TestBooks/Simple/SearchWithGoogle.json");
        }

        static void InitializeSeleniumGrid(string[] args)
        {
            if (SeleniumGridHelper.TestGrid())
            {
                throw new Exception("Error on Grid Initialization, Grid is already started");
            }

            var gridProcess = SeleniumGridHelper.InitializeGrid();

            if (!SeleniumGridHelper.TestGrid())
            {
                gridProcess.Kill();
                throw new Exception("Error on Grid Initialization");
            }


            gridProcess.WaitForExit();
        }
    }
}

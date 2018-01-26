namespace SampleWebTest
{
    using System;
    using System.Diagnostics;
    using System.Net;

    public static class SeleniumGridHelper
    {
        private const string _executeOnStandalone = "SeleniumGrid.ExecuteOnStandalone";
        private const string _standAloneServerVersion = "SeleniumGrid.StandaloneServer.Version";
        public static Process InitializeGrid()
        {
            bool standalone = SeleniumConfigHelper.GetBoolValue(_executeOnStandalone);

            if (standalone)
            {
                string seleniumServerVersion = SeleniumConfigHelper.GetStringValue(_standAloneServerVersion);
                var strCmd = $"/K java -jar ../../SeleniumServer/{seleniumServerVersion}/selenium-server-standalone-{seleniumServerVersion}.jar";
                //var strCmd = $"/K pwd";
                Console.WriteLine($"Executing command : {strCmd}");
                //Process.Start("CMD.exe", strCmd);
                Process process = new Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = strCmd;
                process.Start();

                return process;
            }
            else
            {
                return null;
            }
        }

        public static bool TestGrid()
        {
            WebRequest request = WebRequest.Create("http://127.0.0.1:4444/wd/hub");
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response == null || response.StatusCode != HttpStatusCode.OK)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            
            return true;
        }

    }
}

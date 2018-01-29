namespace SampleWebTest.Common.Helpers
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Remote;
    using System;
    using System.Drawing;
    using System.Globalization;

    public static class WebDriverHelper
    {
        public static IWebDriver CreateSession()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(string.Format("--lang={0}", CultureInfo.CurrentCulture));
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities("chrome", string.Empty, new OpenQA.Selenium.Platform(OpenQA.Selenium.PlatformType.Any));
            desiredCapabilities.SetCapability(ChromeOptions.Capability,
                string.Format(CultureInfo.InvariantCulture, "--lang={0}", CultureInfo.CurrentCulture));

            var chromeDriverPath = Environment.CurrentDirectory + SeleniumConfig.ChromeDriverLocation;
            IWebDriver webDriver = SeleniumConfig.GridEnabled ?
                new RemoteWebDriver(SeleniumConfig.SeleniumHubEndPoint, desiredCapabilities) :
                new ChromeDriver(chromeDriverPath, options, TimeSpan.FromSeconds(60));
            return webDriver;
        }

        public static void ResizeWindow(this IWebDriver webDriver, Size? windowSize)
        {
            if (windowSize != null)
            {
                webDriver.Manage().Window.Size = windowSize.Value;
            }
            else
            {
                webDriver.Manage().Window.Maximize();
            }
        }
    }
}

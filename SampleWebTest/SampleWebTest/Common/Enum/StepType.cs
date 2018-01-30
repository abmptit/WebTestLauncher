using System.ComponentModel;

namespace SampleWebTest.Common.Enum
{
    public enum StepType
    {
        /// <summary>
        /// Create Session
        /// </summary>
        [Description("CREATE_SESSION")]
        CREATE_SESSION = 0,

        /// <summary>
        /// Navigate.
        /// </summary>
        [Description("NAVIGATE_URL")]
        NAVIGATE_URL = 1,

        /// <summary>
        /// Click.
        /// </summary>
        [Description("CLICK_BUTTON")]
        CLICK_BUTTON = 2,

        /// <summary>
        /// Takescreenshot.
        /// </summary>
        [Description("TAKE_SCREENSHOT")]
        TAKE_SCREENSHOT = 12,


        /// <summary>
        /// Takescreenshot.
        /// </summary>
        [Description("RESIZE_WINDOW")]
        RESIZE_WINDOW = 13,
    }
}

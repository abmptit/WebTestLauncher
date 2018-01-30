namespace SampleWebTest.TestBooks.Models
{
    using SampleWebTest.Common.Enum;
    using SampleWebTest.SiteMap.Models;
    using System;

    public class Step
    {
        public string Name { get; set; }

        public StepType Type
        {
            get
            {
                StepType type = (StepType)Enum.Parse(typeof(StepType), Name, true);
                return type;
            }
        }

        public string Description { get; set; }

        public string Url { get; set; }

        public string Page { get; set; }

        public Selector Selector { get; set; }
    }
}
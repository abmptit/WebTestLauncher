namespace SampleWebTest.TestBooks.Models
{
    using SampleWebTest.Common.Enum;

    public class Step
    {
        public string Name { get; set; }

        public StepType Type { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string Page { get; set; }

        public Selector Selector { get; set; }
    }
}
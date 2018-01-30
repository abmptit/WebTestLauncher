namespace SampleWebTest.TestBooks.Models
{
    using SampleWebTest.Common.Enum;


    public class Selector
    {
        public string Name { get; set; }

        public SelectorType Type { get; set; }

        public string XPath { get; set; }
        public string CSS { get; set; }
        public string Id { get; set; }
    }
}
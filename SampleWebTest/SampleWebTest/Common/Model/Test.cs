namespace SampleWebTest.Common.Model
{
    using Enum;
    using System.Collections.Generic;

    public class Test
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Step> Steps { get; set; }

    }
}
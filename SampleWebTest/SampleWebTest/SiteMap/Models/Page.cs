namespace SampleWebTest.SiteMap.Models
{
    using System.Collections.Generic;

    public class Page
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public object Url { get; set; }

        List<Selector> _selectors;
        public List<Selector> Selectors
        {
            get
            {
                if (_selectors == null)
                {
                    _selectors = new List<Selector>();
                }
                return _selectors;
            }
        }
    }
}

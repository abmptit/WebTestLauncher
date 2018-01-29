namespace SampleWebTest.Common.Model.SiteMap
{
    using System.Collections.Generic;

    public class Page
    {
        public string Name { get; set; }

        public string Description { get; set; }

        List<Component> _component;
        public List<Component> Components
        {
            get
            {
                if (_component == null)
                {
                    _component = new List<Component>();
                }
                return _component;
            }
        }
    }
}

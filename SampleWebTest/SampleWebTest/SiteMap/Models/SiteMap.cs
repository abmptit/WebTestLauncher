namespace SampleWebTest.SiteMap.Models
{
    using System;
    using System.Collections.Generic;

    public class SiteMap
    {
        private static volatile SiteMap instance;
        private static object syncRoot = new Object();

        private SiteMap() { }

        public static SiteMap Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SiteMap();
                    }
                }

                return instance;
            }
        }

        public Dictionary<string, Page> Pages = new Dictionary<string, Page>();

        public Page GetPage(string pageKey)
        {
            if (!Pages.ContainsKey(pageKey))
            {
                Pages.Add(pageKey, SiteMapHelper.LoadPageFromJson($"{pageKey}.json"));
            }
            return Pages[pageKey];
        }

    }
}

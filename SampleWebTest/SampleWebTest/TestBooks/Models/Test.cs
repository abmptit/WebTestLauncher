﻿namespace SampleWebTest.TestBooks.Models
{
    using System.Collections.Generic;

    public partial class Test
    {
        public string Name { get; set; }

        public string Description { get; set; }

        List<Step> _steps;
        public List<Step> Steps
        {
            get
            {
                if (_steps == null)
                {
                    _steps = new List<Step>();
                }
                return _steps;
            }
        }
    }
 }
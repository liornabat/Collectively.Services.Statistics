﻿using Coolector.Common.Queries;

namespace Coolector.Services.Statistics.Queries
{
    public class BrowseReporters : IPagedQuery
    {
        public int Page { get; set; }
        public int Results { get; set; }
    }

    public class BrowseResolvers : IPagedQuery
    {
        public int Page { get; set; }
        public int Results { get; set; }
    }
}
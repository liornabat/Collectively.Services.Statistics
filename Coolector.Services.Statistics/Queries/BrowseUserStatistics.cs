﻿using Coolector.Common.Types;

namespace Coolector.Services.Statistics.Queries
{
    public class BrowseUserStatistics : PagedQueryBase
    {
        public string OrderBy { get; set; }
    }
}
﻿using System.Threading.Tasks;
using Coolector.Common.Types;
using Coolector.Services.Statistics.Domain;
using Coolector.Services.Statistics.Shared.Queries;

namespace Coolector.Services.Statistics.Repositories
{
    public interface IUserStatisticsRepository
    {
        Task<Maybe<PagedResult<UserStatistics>>> BrowseAsync(BrowseUserStatistics query);
        Task<Maybe<UserStatistics>> GetByIdAsync(string userId);
        Task<Maybe<UserStatistics>> GetByNameAsync(string name);
        Task UpsertAsync(UserStatistics reporter);
    }
}
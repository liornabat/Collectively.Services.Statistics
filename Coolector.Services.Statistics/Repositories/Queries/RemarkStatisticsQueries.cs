using System;
using System.Threading.Tasks;
using Coolector.Services.Statistics.Domain;
using Coolector.Common.Mongo;
using Coolector.Common.Types;
using Coolector.Services.Statistics.Queries;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Coolector.Services.Statistics.Repositories.Queries
{
    public static class RemarkStatisticsQueries
    {
        public static IMongoCollection<RemarkStatistics> RemarkStatistics(this IMongoDatabase database)
            => database.GetCollection<RemarkStatistics>();

        public static async Task<RemarkStatistics> GetAsync(this IMongoCollection<RemarkStatistics> statistics, Guid remarkId)
            => await statistics.AsQueryable().FirstOrDefaultAsync(x => x.RemarkId == remarkId);

        public static async Task UpsertAsync(this IMongoCollection<RemarkStatistics> statistics, RemarkStatistics value)
            => await statistics.ReplaceOneAsync(x => x.Id == value.Id, value, new UpdateOptions
            {
                IsUpsert = true
            });

        public static IMongoQueryable<RemarkStatistics> Query(this IMongoCollection<RemarkStatistics> statistics, BrowseRemarkStatistics query)
        {
            var values = statistics.AsQueryable();

            return values;
        }        
    }
}
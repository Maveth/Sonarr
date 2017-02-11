using System;
using NzbDrone.Core.SeriesStats;

namespace Sonarr.Api.V3.Series
{
    public class SeriesStatisticsResource
    {
        public int EpisodeFileCount { get; set; }
        public int EpisodeCount { get; set; }
        public int TotalEpisodeCount { get; set; }
        public long SizeOnDisk { get; set; }

        public decimal PercentOfEpisodes
        {
            get
            {
                if (EpisodeCount == 0) return 0;

                return (decimal)EpisodeFileCount / (decimal)EpisodeCount * 100;
            }
        }
    }

    public static class SeriesStatisticsResourceMapper
    {
        public static SeriesStatisticsResource ToResource(this SeriesStatistics model)
        {
            if (model == null) return null;

            return new SeriesStatisticsResource
            {
                EpisodeFileCount = model.EpisodeFileCount,
                EpisodeCount = model.EpisodeCount,
                TotalEpisodeCount = model.TotalEpisodeCount,
                SizeOnDisk = model.SizeOnDisk
            };
        }
    }
}

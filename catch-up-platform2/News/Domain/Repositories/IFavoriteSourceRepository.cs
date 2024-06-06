using catch_up_platform2.News.Model.Aggregates;
using catch_up_platform2.Shared.Domain.Repositories;

namespace catch_up_platform2.News.Domain.Repositories;

public interface IFavoriteSourceRepository : IBaseRepository<FavoriteSource>
{
    Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey);

    Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId);

}
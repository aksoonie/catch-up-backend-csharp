using catch_up_platform2.News.Domain.Repositories;
using catch_up_platform2.News.Model.Aggregates;
using catch_up_platform2.Shared.Infraestructure.Persistence.EFC.Configuration;
using catch_up_platform2.Shared.Infraestructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace catch_up_platform2.News.Infraestructure.Repositories;

public class FavoriteSourcesRepository : BaseRepository<FavoriteSource> , IFavoriteSourceRepository
{
    public FavoriteSourcesRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey)
    {
        return await Context.Set<FavoriteSource>().Where(f => f.NewsApiKey == newsApiKey)
            .ToListAsync();
    }

    public async Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId)
    {
        return await Context.Set<FavoriteSource>().FirstOrDefaultAsync(f => f.NewsApiKey == newsApiKey
                                                                            && f.SourceId == sourceId);
    }
}
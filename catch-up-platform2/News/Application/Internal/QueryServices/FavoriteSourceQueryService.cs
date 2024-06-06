using catch_up_platform2.News.Domain.Repositories;
using catch_up_platform2.News.Domain.Services;
using catch_up_platform2.News.Model.Aggregates;
using catch_up_platform2.News.Model.Queries;

namespace catch_up_platform2.News.Application.Internal.QueriesServices;

public class FavoriteSourceQueryService(IFavoriteSourceRepository favoriteSourceRepository) : IFavoriteSourceQueryService
{
    public async Task<IEnumerable<FavoriteSource>> Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAsync(query.NewsApiKey);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
    {
        return await favoriteSourceRepository.FindByIdAsync(query.Id);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(query.NewsApiKey, query.SourceId);
    }
}
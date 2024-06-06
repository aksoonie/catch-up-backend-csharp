using catch_up_platform2.News.Model.Aggregates;
using catch_up_platform2.News.Model.Queries;

namespace catch_up_platform2.News.Domain.Services;

public interface IFavoriteSourceQueryService
{
    Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
    
    Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);

    Task<IEnumerable<FavoriteSource>> Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query);
}
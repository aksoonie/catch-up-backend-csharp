using catch_up_platform2.News.Interfaces.REST.Resources;
using catch_up_platform2.News.Model.Aggregates;

namespace catch_up_platform2.News.Interfaces.REST.Transform;

public class FavoriteSourceResourceFromEntityAssembler
{
    public static FavoriteSourceResource ToResourceFromEntity(FavoriteSource entity)
        => new FavoriteSourceResource(entity.Id, entity.NewsApiKey, entity.SourceId);
}
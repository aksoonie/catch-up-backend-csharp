using catch_up_platform2.News.Interfaces.REST.Resources;
using catch_up_platform2.News.Model.Commands;

namespace catch_up_platform2.News.Interfaces.REST.Transform;

public class CreateFavoriteSourceCommandFromResourceAssembler
{
    public static CreateFavoriteSourceCommand toCommandFromResource(CreateFavoriteSourceResource resource)
        => new CreateFavoriteSourceCommand(resource.NewsApiKey, resource.SourceId);
}
using catch_up_platform2.News.Model.Aggregates;
using catch_up_platform2.News.Model.Commands;

namespace catch_up_platform2.News.Domain.Services;

public interface IFavoriteSourceCommandService
{
    Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command);
}
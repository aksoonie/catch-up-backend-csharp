using catch_up_platform2.News.Domain.Repositories;
using catch_up_platform2.News.Domain.Services;
using catch_up_platform2.News.Model.Aggregates;
using catch_up_platform2.News.Model.Commands;
using catch_up_platform2.Shared.Domain.Repositories;

namespace catch_up_platform2.News.Application.CommandServices;

public class FavoriteSourceCommandService(IFavoriteSourceRepository favoriteSourceRepository, 
    IUnitOfWork unitOfWork) : IFavoriteSourceCommandService
{
    public async Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command)
    {
        var favoriteSource = await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(
            command.NewsApiKey, command.SourceId);
        if (favoriteSource != null)
            throw new Exception("Favorite source with " +
                                "this SourceId already exists for the given NewsApiKey");
        favoriteSource = new FavoriteSource(command);
        try
        {
            await favoriteSourceRepository.AddAsync(favoriteSource);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return favoriteSource;
    }
}
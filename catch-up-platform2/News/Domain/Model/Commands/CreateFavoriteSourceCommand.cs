namespace catch_up_platform2.News.Model.Commands;

public record CreateFavoriteSourceCommand(string NewsApiKey, 
                                          string SourceId);
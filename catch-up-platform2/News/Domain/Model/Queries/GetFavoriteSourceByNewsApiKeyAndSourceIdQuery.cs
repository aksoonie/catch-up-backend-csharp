namespace catch_up_platform2.News.Model.Queries;

public record GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(string NewsApiKey, 
                                                            string SourceId);
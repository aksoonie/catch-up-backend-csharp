namespace catch_up_platform2.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}
namespace Cumpom.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();

        Task Rollback();
    }
}

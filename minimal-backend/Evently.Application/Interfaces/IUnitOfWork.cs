namespace Evently.Application.Interfaces
{
    public interface IUnitOfWork<T>
    {
        T BeginTransaction();
        Task Commit();
    }
}

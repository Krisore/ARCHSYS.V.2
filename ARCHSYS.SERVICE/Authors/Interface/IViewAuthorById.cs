using ARCHSYS.CORE;

namespace ARCHSYS.SERVICE.Authors.Interface
{
    public interface IViewAuthorById
    {
        Task<Author> ExecuteAsync(int authorId);
    }
}
using ARCHSYS.CORE;

namespace ARCHSYS.SERVICE.Authors.Interface
{
    public interface IViewAuthors
    {
        Task<IEnumerable<Author>> ExecuteAsync();
    }
}
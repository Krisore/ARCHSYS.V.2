using ARCHSYS.CORE;

namespace ARCHSYS.SERVICE.Documents.Interface
{
    public interface IViewDocuments
    {
        Task<IEnumerable<Document>> ExecuteAsync();
    }
}
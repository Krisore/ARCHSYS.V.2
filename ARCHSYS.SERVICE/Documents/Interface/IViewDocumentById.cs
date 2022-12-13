using ARCHSYS.CORE;

namespace ARCHSYS.SERVICE.Documents.Interface
{
    public interface IViewDocumentById
    {
        Task<Document> ExecuteAsync(int documentId);
    }
}
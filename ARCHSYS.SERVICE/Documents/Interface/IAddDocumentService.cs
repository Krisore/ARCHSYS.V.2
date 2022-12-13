using ARCHSYS.CORE;

namespace ARCHSYS.SERVICE.Documents.Interface
{
    public interface IAddDocumentService
    {
        Task ExecuteAsync(Document document);
    }
}
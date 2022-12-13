using ARCHSYS.CORE;

namespace ARCHSYS.SERVICE.Documents.Interface
{
    public interface IEditDocumentService
    {
        Task ExecuteAsync(Document document);
    }
}
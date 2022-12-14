using ARCHSYS.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.SERVICE.PluginInterfaces;

public interface IDocumentRepository
{
    Task AddDocumentAsync(Document document);
    Task<IEnumerable<Document>> GetDocumentsBySearchTermAsync(string searchTermme);
    Task UpdateDocementaryAsync(Document document);
    Task<Document> GetDocumentByIdAsync(int documentId);
    Task<IEnumerable<Document>> GetDocumentsAsync();

}

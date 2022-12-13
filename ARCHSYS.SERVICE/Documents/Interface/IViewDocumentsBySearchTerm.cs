using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Document = ARCHSYS.CORE.Document;

namespace ARCHSYS.SERVICE.Documents.Interface
{
    public interface IViewDocumentsBySearchTerm
    {
        Task<IEnumerable<Document>> ExecuteAsync(string searchTerm = "");
    }
}

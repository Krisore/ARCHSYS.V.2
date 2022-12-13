using ARCHSYS.SERVICE.Documents.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ARCHSYS.CORE;
using Document = ARCHSYS.CORE.Document;
using ARCHSYS.SERVICE.PluginInterfaces;

namespace ARCHSYS.SERVICE.Documents
{
    public class ViewDocumentsBySearchTerm : IViewDocumentsBySearchTerm
    {
        private readonly IDocumentRepository documentRepository;

        public ViewDocumentsBySearchTerm(IDocumentRepository documentRepository)
        {
            this.documentRepository = documentRepository;
        }
        public async Task<IEnumerable<Document>> ExecuteAsync (string searchTerm = "") 
            => await documentRepository.GetDocumentsBySearchTermAsync(searchTerm);
    }
}

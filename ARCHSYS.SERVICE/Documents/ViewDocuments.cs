using ARCHSYS.CORE;
using ARCHSYS.SERVICE.Documents.Interface;
using ARCHSYS.SERVICE.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.SERVICE.Documents
{
    public class ViewDocuments : IViewDocuments
    {
        private readonly IDocumentRepository documentRepository;

        public ViewDocuments(IDocumentRepository documentRepository)
        {
            this.documentRepository = documentRepository;
        }
        public async Task<IEnumerable<Document>> ExecuteAsync()
            => await documentRepository.GetDocumentsAsync();
    }
}

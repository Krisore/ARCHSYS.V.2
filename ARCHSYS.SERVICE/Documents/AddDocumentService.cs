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
    public class AddDocumentService : IAddDocumentService
    {
        private readonly IDocumentRepository documentRepository;

        public AddDocumentService(IDocumentRepository documentRepository)
        {
            this.documentRepository = documentRepository;
        }
        public async Task ExecuteAsync(Document document)
        {
            await this.documentRepository.AddDocumentAsync(document);
        }
    }
}

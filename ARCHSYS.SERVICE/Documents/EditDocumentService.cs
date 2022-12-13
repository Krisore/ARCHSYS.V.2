using ARCHSYS.CORE;
using ARCHSYS.SERVICE.Documents.Interface;
using ARCHSYS.SERVICE.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Document = ARCHSYS.CORE.Document;

namespace ARCHSYS.SERVICE.Documents;

public class EditDocumentService : IEditDocumentService
{
    private readonly IDocumentRepository documentRepository;

    public EditDocumentService(IDocumentRepository documentRepository)
    {
        this.documentRepository = documentRepository;
    }
    public async Task ExecuteAsync(Document document)
    {
        await this.documentRepository.UpdateDocementaryAsync(document);
    }
}

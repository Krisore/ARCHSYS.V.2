using ARCHSYS.CORE;
using ARCHSYS.SERVICE.Documents.Interface;
using ARCHSYS.SERVICE.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.SERVICE.Documents;

public class ViewDocumentById : IViewDocumentById
{
    private readonly IDocumentRepository documentRepository;

    public ViewDocumentById(IDocumentRepository documentRepository)
    {
        this.documentRepository = documentRepository;
    }
    public async Task<Document> ExecuteAsync(int documentId) => await documentRepository.GetDocumentByIdAsync(documentId);
}

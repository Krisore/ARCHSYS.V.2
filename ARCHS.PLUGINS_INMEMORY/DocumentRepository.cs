using ARCHSYS.CORE;
using ARCHSYS.SERVICE.PluginInterfaces;

namespace ARCHSYS.PLUGINS_INMEMORY;

public class DocumentRepository : IDocumentRepository
{
    private readonly ARCHSYSContext database;

    public DocumentRepository(ARCHSYSContext database)
    {
        this.database = database;
    }

    public Task AddDocumentAsync(Document document)
    {
        if (database.Documents.Any(d => d.Title.Equals(document.Title, StringComparison.OrdinalIgnoreCase))) return Task.CompletedTask;
        var maxId = database.Documents.Max(d => d.Id);
        document.Id = maxId + 2;
        database.Documents.Add(document);
        return Task.CompletedTask;
    }

    public async Task<Document> GetDocumentByIdAsync(int documentId)
    {
        var document = await Task.FromResult(database.Documents.FirstOrDefault(d => d.Id == documentId));
        var newDocument = new Document
        {
            Id = document.Id,
            Title = document.Title,
            ShortDiscription = document.ShortDiscription,
            DatePublished = document.DatePublished,
        };
        return await Task.FromResult(newDocument);
    }

    public async Task<IEnumerable<Document>> GetDocumentsAsync()
    {
        return await Task.FromResult(database.Documents);
    }

    public async Task<IEnumerable<Document>> GetDocumentsBySearchTermAsync(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm)) return await Task.FromResult(database.Documents);
        return database.Documents.Where(d => d.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                d.ShortDiscription.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                d.DatePublished.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }

    public Task UpdateDocementaryAsync(Document document)
    {
        if (database.Documents.Any(d => d.Id == document.Id && d.Title.Equals(document.Title, StringComparison.OrdinalIgnoreCase))) return Task.CompletedTask;
        var currentDocument = database.Documents.FirstOrDefault(d => d.Id == document.Id);
        if (currentDocument != null)
        {
            currentDocument.Id = document.Id;
            currentDocument.Title = document.Title;
            currentDocument.ShortDiscription = document.ShortDiscription;
            currentDocument.DatePublished = document.DatePublished;
        }
        return Task.CompletedTask;

    }
}
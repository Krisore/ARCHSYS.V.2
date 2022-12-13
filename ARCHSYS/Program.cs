using ARCHSYS.SERVICE.PluginInterfaces;
using ARCHSYS.SERVICE.Documents;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;
using ARCHSYS.SERVICE.Documents.Interface;
using ARCHSYS.PLUGINS_INMEMORY;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMudServices();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<ARCHSYSContext>(options => 
{ 
    options.UseInMemoryDatabase("ARCHSYS"); 
});

#region  Dependency Injection of Repositories | Db Context
builder.Services.AddTransient<IViewDocumentsBySearchTerm, ViewDocumentsBySearchTerm>();
#endregion

#region Dependency Injection of Services | Use Cases
builder.Services.AddTransient<IAddDocumentService, AddDocumentService>();
builder.Services.AddTransient<IEditDocumentService, EditDocumentService>();
builder.Services.AddTransient<IViewDocumentById, ViewDocumentById>();
builder.Services.AddTransient<IDocumentRepository, DocumentRepository>();
#endregion


var app = builder.Build();

var scope = app.Services.CreateScope();
var ArchsysContext = scope.ServiceProvider.GetRequiredService<ARCHSYSContext>();
ArchsysContext.Database.EnsureDeleted();
ArchsysContext.Database.EnsureCreated();
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
using ARCHSYS.CORE;
using ARCHSYS.SERVICE.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.PLUGINS_INMEMORY;

public class AuthorRepository : IAuthorRepository
{
	private readonly ARCHSYSContext database;

	public AuthorRepository(ARCHSYSContext database)
	{
		this.database = database;
	}

	public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
	{
		return await Task.FromResult(database.Authors);
	}

	public async  Task<Author> GetAuthorByIdAsync(int authorId)
	{

		var currentAuthor = await Task.FromResult(database.Authors.FirstOrDefault(author => author.AuthorId == authorId));
		var newAuthor  = new Author
		{
				AuthorId = currentAuthor.AuthorId,
				FirstName = currentAuthor.FirstName,
				LastName = currentAuthor.LastName,
				MiddleInitial = currentAuthor.MiddleInitial,
				AcademicProgram = currentAuthor.AcademicProgram,
				DocumentId = currentAuthor.DocumentId,
		};
		return await Task.FromResult(newAuthor);
		
		
	}
}

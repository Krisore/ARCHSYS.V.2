using ARCHSYS.SERVICE.PluginInterfaces;
using ARCHSYS.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARCHSYS.SERVICE.Authors.Interface;
using System.Reflection.Metadata;

namespace ARCHSYS.SERVICE.Authors
{
    public class ViewAuthorById : IViewAuthorById
    {
        private readonly IAuthorRepository authorRepository;

        public ViewAuthorById(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<Author> ExecuteAsync(int authorId)
        {
            return await authorRepository.GetAuthorByIdAsync(authorId);
        }
    }
}

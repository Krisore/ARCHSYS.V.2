using ARCHSYS.CORE;
using ARCHSYS.SERVICE.Authors.Interface;
using ARCHSYS.SERVICE.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHSYS.SERVICE.Authors
{
    public class ViewAuthors : IViewAuthors
    {
        private readonly IAuthorRepository authorRepository;

        public ViewAuthors(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        public async Task<IEnumerable<Author>> ExecuteAsync() => await authorRepository.GetAllAuthorsAsync();
    }
}

using LibraryManagement.Books;
using LibraryManagement.Dtos.Books;
using LibraryManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LibraryManagement.Services
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateBookDto, UpdateBookDto>, IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository) : base(repository) 
        {
                
        }
    }
}

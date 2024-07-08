using LibraryManagement.Dtos.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LibraryManagement.Interfaces
{
    public interface IBookAppService : ICrudAppService<BookDto, Guid, PagedAndSortedResultRequestDto, CreateBookDto, UpdateBookDto>
    {
/*        Task<BookDto> CreateAsync(CreateBookDto book);
        Task<BookDto> GetByIdAsync(Guid id);
        Task<PagedResultDto<BookDto>> GetListAsync(GetBooksListDto dto);
        Task<BookDto> UpdateAsync(UpdateBookDto book);
        Task DeleteAsync(Guid id);*/
    }
}

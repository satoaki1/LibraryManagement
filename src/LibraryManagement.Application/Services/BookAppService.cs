using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using LibraryManagement.Dtos;
using LibraryManagement.Models;

namespace LibraryManagement.Services
{
	public class BookAppService : CrudAppService<
		Book,
		BookDto,
		Guid,
		PagedAndSortedResultRequestDto,
		CreateBookDto,
		UpdateBookDto>
	{
		public BookAppService(IRepository<Book, Guid> repository) : base(repository)
		{

		}
	}
}
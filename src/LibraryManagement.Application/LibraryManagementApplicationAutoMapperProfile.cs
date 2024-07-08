using AutoMapper;
using LibraryManagement.Books;
using LibraryManagement.Dtos.Books;

namespace LibraryManagement;

public class LibraryManagementApplicationAutoMapperProfile : Profile
{
    public LibraryManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<Book, CreateBookDto>();
        CreateMap<Book, UpdateBookDto>();
    }
}

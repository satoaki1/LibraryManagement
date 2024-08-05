using AutoMapper;
<<<<<<< Updated upstream
using LibraryManagement.Books;
using LibraryManagement.Dtos.Books;
=======
using LibraryManagement.Models;
using LibraryManagement.Dtos;
>>>>>>> Stashed changes

namespace LibraryManagement;

public class LibraryManagementApplicationAutoMapperProfile : Profile
{
    public LibraryManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
<<<<<<< Updated upstream
        CreateMap<Book, CreateBookDto>();
        CreateMap<Book, UpdateBookDto>();
=======
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
>>>>>>> Stashed changes
    }
}

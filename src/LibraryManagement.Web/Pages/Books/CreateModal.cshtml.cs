using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using LibraryManagement.Books;
using LibraryManagement.Models;
using LibraryManagement.Interfaces;
using LibraryManagement.Dtos;
using LibraryManagement.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LibraryManagement.Web.Pages.Books
{
    public class CreateModalModel : PageModel
    {
        [BindProperty]
        public CreateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateBookDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return Page();
        }
    }
}

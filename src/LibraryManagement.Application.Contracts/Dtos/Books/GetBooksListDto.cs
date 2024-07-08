using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace LibraryManagement.Dtos.Books
{
    public class GetBooksListDto : PagedResultRequestDto
    {
        public string? Filter { get; set; }
        public string? Sorting { get; set; }
    }
}

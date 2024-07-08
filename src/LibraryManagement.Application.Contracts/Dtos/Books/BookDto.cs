using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Books;
using Volo.Abp.Application.Dtos;

namespace LibraryManagement.Dtos.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }
        public Status Status { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime DateOfIntroduced { get; set; }
    }
}

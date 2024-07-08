using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Books;
using Volo.Abp.Application.Dtos;

namespace LibraryManagement.Dtos.Books
{
    public class UpdateBookDto : EntityDto<Guid>
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string AuthorName { get; set; }

        public string? Description { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfIntroduced { get; set; }
    }
}

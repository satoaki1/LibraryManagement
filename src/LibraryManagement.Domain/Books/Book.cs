using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace LibraryManagement.Books
{
    public class Book : FullAuditedAggregateRoot<Guid>
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
